namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingDetailService : BusinessObject<JobPostingDetail>, IJobPostingDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<JobPostingDetail> Validator;

		public JobPostingDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<JobPostingDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<JobPostingDetail>> InsertAsync(JobPostingDetailInsert Model)
		{
			try
			{
				Data = Mapper.Map<JobPostingDetail>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<JobPostingDetail>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.JobPostingDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<JobPostingDetail>.SuccessResult(Data, "Record has been success")
					: DataService<JobPostingDetail>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<JobPostingDetail>> UpdateAsync(JobPostingDetailUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<JobPostingDetail>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.JobPostingDetail.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPostingDetail>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<JobPostingDetail>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<JobPostingDetail>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<JobPostingDetail>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.JobPostingDetail.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPostingDetail>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<JobPostingDetail>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<JobPostingDetail>> SelectAsync(JobPostingDetailSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.IsActive);
				return DataService<JobPostingDetail>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<JobPostingDetail>> SelectSingleAsync(JobPostingDetailSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<JobPostingDetail>.FailureResult("Kayıt bulunamadı");
				return DataService<JobPostingDetail>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}