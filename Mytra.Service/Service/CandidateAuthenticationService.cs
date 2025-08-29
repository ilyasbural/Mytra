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
			return new ServiceResponse<CandidateAuthenticationResponse>
			{

			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> UpdateAsync(CandidateAuthenticationUpdate Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{

			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> DeleteAsync(CandidateAuthenticationDelete Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{

			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectAsync(CandidateAuthenticationSelect Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{

			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectSingleAsync(CandidateAuthenticationSelectSingle Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{

			};
		}
	}
}