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
			return new ServiceResponse<UserResponse>()
			{
				//IsSuccess = true,
				//Message = "User inserted successfully",
				//Data = new UserResponse { Id = 1, Username = Model.Username, Email = Model.Email }
			};
		}

		public async Task<ServiceResponse<UserResponse>> UpdateAsync(UserUpdate Model)
		{
			return new ServiceResponse<UserResponse>()
			{
				
			};
		}

		public async Task<ServiceResponse<UserResponse>> DeleteAsync(UserDelete Model)
		{
			return new ServiceResponse<UserResponse>()
			{

			};
		}

		public async Task<ServiceResponse<UserResponse>> SelectAsync(UserSelect Model)
		{
			return new ServiceResponse<UserResponse>()
			{

			};
		}

		public async Task<ServiceResponse<UserResponse>> SelectSingleAsync(UserSelectSingle Model)
		{
			return new ServiceResponse<UserResponse>()
			{

			};
		}
	}
}