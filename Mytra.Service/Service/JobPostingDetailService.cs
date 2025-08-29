namespace Mytra.Service
{
	using Core;
	using Common;
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

		public async Task<ServiceResponse<JobPostingDetailResponse>> InsertAsync(JobPostingDetailInsert Model)
		{
			Data = Mapper.Map<JobPostingDetail>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<JobPostingDetail>(Data);
			await UnitOfWork.JobPostingDetail.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<JobPostingDetailResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<JobPostingDetailResponse>(Data)
			};
		}

		public async Task<ServiceResponse<JobPostingDetailResponse>> UpdateAsync(JobPostingDetailUpdate Model)
		{
			return new ServiceResponse<JobPostingDetailResponse>
			{
				//IsSuccess = true,
				//Message = "Job posting details updated successfully.",
				//Data = new JobPostingDetailResponse
				//{
				//	Id = Model.Id,
				//	JobTitle = Model.JobTitle,
				//	Description = Model.Description,
				//	Location = Model.Location,
				//	PostedDate = DateTime.UtcNow
				//}
			};
		}

		public async Task<ServiceResponse<JobPostingDetailResponse>> DeleteAsync(JobPostingDetailDelete Model)
		{
			return new ServiceResponse<JobPostingDetailResponse>
			{
				//IsSuccess = true,
				//Message = "Job posting details deleted successfully.",
				//Data = null
			};
		}

		public async Task<ServiceResponse<JobPostingDetailResponse>> SelectAsync(JobPostingDetailSelect Model)
		{
			return new ServiceResponse<JobPostingDetailResponse>
			{
				//IsSuccess = true,
				//Message = "Job posting details retrieved successfully.",
				//Data = new JobPostingDetailResponse
				//{
				//	Id = Guid.NewGuid(),
				//	JobTitle = "Sample Job Title",
				//	Description = "Sample Job Description",
				//	Location = "Sample Location",
				//	PostedDate = DateTime.UtcNow
				//}
			};
		}

		public async Task<ServiceResponse<JobPostingDetailResponse>> SelectSingleAsync(JobPostingDetailSelectSingle Model)
		{
			return new ServiceResponse<JobPostingDetailResponse>
			{
				//IsSuccess = true,
				//Message = "Job posting detail retrieved successfully.",
				//Data = new JobPostingDetailResponse
				//{
				//	Id = Model.Id,
				//	JobTitle = "Sample Job Title",
				//	Description = "Sample Job Description",
				//	Location = "Sample Location",
				//	PostedDate = DateTime.UtcNow
				//}
			};
		}
	}
}