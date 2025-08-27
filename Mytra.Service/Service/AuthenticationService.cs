namespace Mytra.Service
{
	using Core;
	using Common;

	public class AuthenticationService : IAuthenticationService
	{
		public AuthenticationService()
		{
			
		}

		public async Task<ServiceResponse<AuthenticationResponse>> AuthenticationAsync(Authentication Model)
		{
			throw new NotImplementedException();
		}
	}
}