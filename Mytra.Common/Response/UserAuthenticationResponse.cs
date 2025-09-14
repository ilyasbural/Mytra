namespace Mytra.Common
{
	public class UserAuthenticationResponse : Response<UserAuthenticationResponse>
	{
		public String Name { get; set; } = String.Empty;
		public UserAuthenticationResponse() { }
	}
}