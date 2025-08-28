namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateService : ICandidateService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Candidate> Validator;

		public CandidateService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Candidate> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateResponse>> InsertAsync(CandidateInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateResponse>> UpdateAsync(CandidateUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateResponse>> DeleteAsync(CandidateDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateResponse>> SelectAsync(CandidateSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateResponse>> SelectSingleAsync(CandidateSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}