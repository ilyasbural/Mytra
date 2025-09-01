namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingService : BusinessObject<JobPosting>, IJobPostingService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<JobPosting> Validator;

		public JobPostingService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<JobPosting> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<JobPosting>> InsertAsync(JobPostingInsert Model)
		{
			try
			{
				Data = Mapper.Map<JobPosting>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<JobPosting>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.JobPosting.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<JobPosting>.SuccessResult(Data, "Record has been success")
					: DataService<JobPosting>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<JobPosting>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<JobPosting>> UpdateAsync(JobPostingUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPosting.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<JobPosting>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.JobPosting.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPosting>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<JobPosting>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<JobPosting>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<JobPosting>> DeleteAsync(JobPostingDelete Model)
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

		public async Task<DataService<JobPosting>> SelectAsync(JobPostingSelect Model)
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

		public async Task<DataService<JobPosting>> SelectSingleAsync(JobPostingSelectSingle Model)
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

		//public async Task<ServiceResponse<JobPostingResponse>> DeleteAsync(JobPostingDelete Model)
		//{
		//	Collection = await UnitOfWork.JobPosting.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	JobPosting JobPosting = Collection.SingleOrDefault()!;
		//	await UnitOfWork.JobPosting.DeleteAsync(JobPosting);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<JobPostingResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<JobPostingResponse>(JobPosting)
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingResponse>> SelectAsync(JobPostingSelect Model)
		//{
		//	return new ServiceResponse<JobPostingResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<JobPostingResponse>>
		//		(await UnitOfWork.JobPosting.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingResponse>> SelectSingleAsync(JobPostingSelectSingle Model)
		//{
		//	return new ServiceResponse<JobPostingResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<JobPostingResponse>>
		//		(await UnitOfWork.JobPosting.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}