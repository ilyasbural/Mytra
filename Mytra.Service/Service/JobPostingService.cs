namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingService : IJobPostingService
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

		public async Task<ServiceResponse<JobPostingResponse>> InsertAsync(JobPostingInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingResponse>> UpdateAsync(JobPostingUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingResponse>> DeleteAsync(JobPostingDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingResponse>> SelectAsync(JobPostingSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingResponse>> SelectSingleAsync(JobPostingSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}