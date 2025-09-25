namespace Mytra.Utilize
{
	public class UserAuthenticationResponse : Response<UserAuthenticationResponse>
	{
		public String RefreshToken { get; set; } = String.Empty;
		public DateTime RefreshTokenExpireTime { get; set; }
		public UserAuthenticationResponse() { }
	}
}