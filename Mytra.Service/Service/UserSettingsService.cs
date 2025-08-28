namespace Mytra.Service
{
    using Core;
	using Common;

	public class UserSettingsService : IUserSettingsService
	{
		public UserSettingsService()
		{
			
		}

		public async Task<ServiceResponse<UserSettingsResponse>> InsertAsync(UserSettingsInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserSettingsResponse>> UpdateAsync(UserSettingsUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserSettingsResponse>> DeleteAsync(UserSettingsDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserSettingsResponse>> SelectAsync(UserSettingsSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserSettingsResponse>> SelectSingleAsync(UserSettingsSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}