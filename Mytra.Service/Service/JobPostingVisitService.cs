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

		public async Task<ServiceResponse<JobPostingVisitResponse>> InsertAsync(JobPostingVisitInsert Model)
		{
			Data = Mapper.Map<JobPostingVisit>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<JobPostingVisit>(Data);
			await UnitOfWork.JobPostingVisit.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<JobPostingVisitResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<JobPostingVisitResponse>(Data)
			};
		}

		public async Task<ServiceResponse<JobPostingVisitResponse>> UpdateAsync(JobPostingVisitUpdate Model)
		{
			return new ServiceResponse<JobPostingVisitResponse>
			{
				//IsSuccess = true,
				//Message = "Job posting visit updated successfully.",
				//Data = null // In a real implementation, this would be the updated JobPostingVisitResponse object.
			};
		}

		public async Task<ServiceResponse<JobPostingVisitResponse>> DeleteAsync(JobPostingVisitDelete Model)
		{
			return new ServiceResponse<JobPostingVisitResponse>
			{
				//IsSuccess = true,
				//Message = "Job posting visit deleted successfully.",
				//Data = null // In a real implementation, this might be null or some confirmation object.
			};
		}

		public async Task<ServiceResponse<JobPostingVisitResponse>> SelectAsync(JobPostingVisitSelect Model)
		{
			return new ServiceResponse<JobPostingVisitResponse>
			{
				//IsSuccess = true,
				//Message = "Job posting visits retrieved successfully.",
				//Data = null // In a real implementation, this would be a list of JobPostingVisitResponse objects.
			};
		}

		public async Task<ServiceResponse<JobPostingVisitResponse>> SelectSingleAsync(JobPostingVisitSelectSingle Model)
		{
			return new ServiceResponse<JobPostingVisitResponse>
			{
				//IsSuccess = true,
				//Message = "Job posting visit retrieved successfully.",
				//Data = null // In a real implementation, this would be the requested JobPostingVisitResponse object.
			};
		}
	}
}