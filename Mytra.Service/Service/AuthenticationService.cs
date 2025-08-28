namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class AuthenticationService : IAuthenticationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateAuthentication> Validator;

		public AuthenticationService()
		{
			
		}

		public async Task<ServiceResponse<AuthenticationResponse>> AuthenticationAsync(Authentication Model)
		{
			throw new NotImplementedException();
		}
	}
}