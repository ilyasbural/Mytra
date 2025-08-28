namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingDetailService : IJobPostingDetailService
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
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingDetailResponse>> UpdateAsync(JobPostingDetailUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingDetailResponse>> DeleteAsync(JobPostingDetailDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingDetailResponse>> SelectAsync(JobPostingDetailSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingDetailResponse>> SelectSingleAsync(JobPostingDetailSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}