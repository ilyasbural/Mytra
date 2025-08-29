namespace Mytra.Service
{
	using AutoMapper;
	using Common;
	using Core;
	using FluentValidation;
	using static System.Runtime.InteropServices.JavaScript.JSType;

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