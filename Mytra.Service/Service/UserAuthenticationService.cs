namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class UserAuthenticationService : IUserAuthenticationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<UserAuthentication> Validator;

		public UserAuthenticationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserAuthentication> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<UserAuthenticationResponse>> InsertAsync(UserAuthenticationInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserAuthenticationResponse>> UpdateAsync(UserAuthenticationUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserAuthenticationResponse>> DeleteAsync(UserAuthenticationDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserAuthenticationResponse>> SelectAsync(UserAuthenticationSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserAuthenticationResponse>> SelectSingleAsync(UserAuthenticationSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}