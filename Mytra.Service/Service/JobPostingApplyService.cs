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

		//public async Task<ServiceResponse<JobPostingApplyResponse>> UpdateAsync(JobPostingApplyUpdate Model)
		//{
		//	Collection = await UnitOfWork.JobPostingApply.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	JobPostingApply JobPostingApply = Collection.SingleOrDefault()!;
		//	JobPostingApply.Name = Model.Name;
		//	await UnitOfWork.JobPostingApply.UpdateAsync(JobPostingApply);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<JobPostingApplyResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<JobPostingApplyResponse>(JobPostingApply)
		//	};
		//}

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