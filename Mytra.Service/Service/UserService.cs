namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class UserService : IUserService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<User> Validator;

		public UserService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<User> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<UserResponse>> InsertAsync(UserInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserResponse>> UpdateAsync(UserUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserResponse>> DeleteAsync(UserDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserResponse>> SelectAsync(UserSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserResponse>> SelectSingleAsync(UserSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}