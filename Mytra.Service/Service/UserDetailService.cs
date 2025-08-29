namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class UserDetailService : IUserDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<UserDetail> Validator;

		public UserDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<UserDetailResponse>> InsertAsync(UserDetailInsert Model)
		{
			return new ServiceResponse<UserDetailResponse>()
			{
				//IsSuccess = true,
				//Message = "User detail inserted successfully",
				//Data = new UserDetailResponse()
				//{
				//	UserId = 1,
				//	FirstName = Model.FirstName,
				//	LastName = Model.LastName,
				//	Email = Model.Email,
				//	PhoneNumber = Model.PhoneNumber
				//}
			};
		}

		public async Task<ServiceResponse<UserDetailResponse>> UpdateAsync(UserDetailUpdate Model)
		{
			return new ServiceResponse<UserDetailResponse>()
			{
				//IsSuccess = true,
				//Message = "User detail updated successfully",
				//Data = new UserDetailResponse()
				//{
				//	UserId = Model.UserId,
				//	FirstName = Model.FirstName,
				//	LastName = Model.LastName,
				//	Email = Model.Email,
				//	PhoneNumber = Model.PhoneNumber
				//}
			};
		}

		public async Task<ServiceResponse<UserDetailResponse>> DeleteAsync(UserDetailDelete Model)
		{
			return new ServiceResponse<UserDetailResponse>()
			{
				
			};
		}

		public async Task<ServiceResponse<UserDetailResponse>> SelectAsync(UserDetailSelect Model)
		{
			return new ServiceResponse<UserDetailResponse>()
			{
				
			};
		}

		public async Task<ServiceResponse<UserDetailResponse>> SelectSingleAsync(UserDetailSelectSingle Model)
		{
			return new ServiceResponse<UserDetailResponse>()
			{
				
			};
		}
	}
}