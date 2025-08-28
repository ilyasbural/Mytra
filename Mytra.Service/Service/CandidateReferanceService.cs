namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateReferanceService : ICandidateReferanceService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateReferance> Validator;

		public CandidateReferanceService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateReferance> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> InsertAsync(CandidateReferanceInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> UpdateAsync(CandidateReferanceUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> DeleteAsync(CandidateReferanceDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> SelectAsync(CandidateReferanceSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> SelectSingleAsync(CandidateReferanceSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}