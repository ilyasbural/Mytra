namespace Mytra.Service
{
    using Core;
	using Common;

	public class UserService : IUserService
	{
		public UserService()
		{
			
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