namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingVisitService : BusinessObject<JobPostingVisit>, IJobPostingVisitService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<JobPostingVisit> Validator;

		public JobPostingVisitService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<JobPostingVisit> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<JobPostingVisit>> InsertAsync(JobPostingVisitInsert Model)
		{
			try
			{
				Data = Mapper.Map<JobPostingVisit>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<JobPostingVisit>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.JobPostingVisit.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<JobPostingVisit>.SuccessResult(Data, "Record has been success")
					: DataService<JobPostingVisit>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingVisit>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<JobPostingVisit>> UpdateAsync(JobPostingVisitUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingVisit.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<JobPostingVisit>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.JobPostingVisit.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPostingVisit>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<JobPostingVisit>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingVisit>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<JobPostingVisit>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingVisit.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<JobPostingVisit>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.JobPostingVisit.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPostingVisit>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<JobPostingVisit>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingVisit>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<JobPostingVisit>> SelectAsync(JobPostingVisitSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingVisit.SelectAsync(x => x.IsActive);
				return DataService<JobPostingVisit>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingVisit>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<JobPostingVisit>> SelectSingleAsync(JobPostingVisitSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingVisit.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<JobPostingVisit>.FailureResult("Kayıt bulunamadı");
				return DataService<JobPostingVisit>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingVisit>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}