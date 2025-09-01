namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingApplyService : BusinessObject<JobPostingApply>, IJobPostingApplyService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<JobPostingApply> Validator;

		public JobPostingApplyService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<JobPostingApply> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<JobPostingApply>> InsertAsync(JobPostingApplyInsert Model)
		{
			try
			{
				Data = Mapper.Map<JobPostingApply>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<JobPostingApply>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.JobPostingApply.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<JobPostingApply>.SuccessResult(Data, "Record has been success")
					: DataService<JobPostingApply>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingApply>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<JobPostingApply>> UpdateAsync(JobPostingApplyUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingApply.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<JobPostingApply>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.JobPostingApply.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPostingApply>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<JobPostingApply>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingApply>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<JobPostingApply>> DeleteAsync(JobPostingApplyDelete Model)
		{
			try
			{
				Collection = await UnitOfWork.Candidate.SelectAsync(x => x.Id == Model.Id);
				if (Collection.SingleOrDefault() == null) return DataService<Candidate>.FailureResult("Kayıt bulunamadı");

				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Candidate>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<Candidate>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<Candidate>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<JobPostingApply>> SelectAsync(JobPostingApplySelect Model)
		{
			try
			{
				Collection = await UnitOfWork.Candidate.SelectAsync(x => x.IsActive);
				return DataService<Candidate>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<Candidate>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<JobPostingApply>> SelectSingleAsync(JobPostingApplySelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.Candidate.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<Candidate>.FailureResult("Kayıt bulunamadı");
				return DataService<Candidate>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<Candidate>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}

		//public async Task<ServiceResponse<JobPostingApplyResponse>> DeleteAsync(JobPostingApplyDelete Model)
		//{
		//	Collection = await UnitOfWork.JobPostingApply.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	JobPostingApply JobPostingApply = Collection.SingleOrDefault()!;
		//	await UnitOfWork.JobPostingApply.DeleteAsync(JobPostingApply);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<JobPostingApplyResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<JobPostingApplyResponse>(JobPostingApply)
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingApplyResponse>> SelectAsync(JobPostingApplySelect Model)
		//{
		//	return new ServiceResponse<JobPostingApplyResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<JobPostingApplyResponse>>
		//		(await UnitOfWork.JobPostingApply.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingApplyResponse>> SelectSingleAsync(JobPostingApplySelectSingle Model)
		//{
		//	return new ServiceResponse<JobPostingApplyResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<JobPostingApplyResponse>>
		//		(await UnitOfWork.JobPostingApply.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}