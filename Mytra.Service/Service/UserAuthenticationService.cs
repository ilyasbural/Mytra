namespace Mytra.Service
{
    using Core;
	using Common;

	public class UserAuthenticationService : IUserAuthenticationService
	{
		public UserAuthenticationService()
		{
			
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