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
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserDetailResponse>> UpdateAsync(UserDetailUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserDetailResponse>> DeleteAsync(UserDetailDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserDetailResponse>> SelectAsync(UserDetailSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserDetailResponse>> SelectSingleAsync(UserDetailSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}