namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingVisitService : IJobPostingVisitService
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
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingVisitResponse>> UpdateAsync(JobPostingVisitUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingVisitResponse>> DeleteAsync(JobPostingVisitDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingVisitResponse>> SelectAsync(JobPostingVisitSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingVisitResponse>> SelectSingleAsync(JobPostingVisitSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}