namespace Mytra.Service
{
    using Core;
	using Common;

	public class UserDetailService : IUserDetailService
	{
		public UserDetailService()
		{
			
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