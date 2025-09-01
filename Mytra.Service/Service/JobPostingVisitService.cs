namespace Mytra.Service
{
	using Core;
	using Common;
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

		public async Task<DataService<JobPostingVisit>> DeleteAsync(JobPostingVisitDelete Model)
		{
			throw new NotImplementedException();
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

				await UnitOfWork.JobPostingVisit.InsertAsync(Data);
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

		public async Task<DataService<JobPostingVisit>> SelectAsync(JobPostingVisitSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<JobPostingVisit>> SelectSingleAsync(JobPostingVisitSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<JobPostingVisit>> UpdateAsync(JobPostingVisitUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingVisit.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null)
					return DataService<JobPostingVisit>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.JobPostingVisit.InsertAsync(Data);
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

		//public async Task<ServiceResponse<JobPostingVisitResponse>> UpdateAsync(JobPostingVisitUpdate Model)
		//{
		//	Collection = await UnitOfWork.JobPostingVisit.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	JobPostingVisit JobPostingVisit = Collection.SingleOrDefault()!;
		//	JobPostingVisit.Name = Model.Name;
		//	await UnitOfWork.JobPostingVisit.UpdateAsync(JobPostingVisit);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<JobPostingVisitResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<JobPostingVisitResponse>(JobPostingVisit)
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingVisitResponse>> DeleteAsync(JobPostingVisitDelete Model)
		//{
		//	Collection = await UnitOfWork.JobPostingVisit.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	JobPostingVisit JobPostingVisit = Collection.SingleOrDefault()!;
		//	await UnitOfWork.JobPostingVisit.DeleteAsync(JobPostingVisit);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<JobPostingVisitResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<JobPostingVisitResponse>(JobPostingVisit)
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingVisitResponse>> SelectAsync(JobPostingVisitSelect Model)
		//{
		//	return new ServiceResponse<JobPostingVisitResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<JobPostingVisitResponse>>
		//		(await UnitOfWork.JobPostingVisit.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingVisitResponse>> SelectSingleAsync(JobPostingVisitSelectSingle Model)
		//{
		//	return new ServiceResponse<JobPostingVisitResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<JobPostingVisitResponse>>
		//		(await UnitOfWork.JobPostingVisit.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}