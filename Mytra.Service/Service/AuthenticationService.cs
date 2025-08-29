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

		public AuthenticationService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		public async Task<ServiceResponse<AuthenticationResponse>> AuthenticationAsync(Authentication Model)
		{
			return new ServiceResponse<AuthenticationResponse>()
			{

			};
		}
	}
}