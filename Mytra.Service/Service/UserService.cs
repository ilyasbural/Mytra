namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class UserService : BusinessObject<User>, IUserService
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
			Data = Mapper.Map<User>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<User>(Data);
			await UnitOfWork.User.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<UserResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<UserResponse>(Data)
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