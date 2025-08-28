namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateAuthenticationService : ICandidateAuthenticationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateAuthentication> Validator;

		public CandidateAuthenticationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateAuthentication> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> InsertAsync(CandidateAuthenticationInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> UpdateAsync(CandidateAuthenticationUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> DeleteAsync(CandidateAuthenticationDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectAsync(CandidateAuthenticationSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectSingleAsync(CandidateAuthenticationSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}