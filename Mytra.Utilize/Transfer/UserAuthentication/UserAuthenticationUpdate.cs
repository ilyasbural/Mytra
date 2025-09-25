namespace Mytra.Utilize
{
	public class UserAuthenticationUpdate
	{
		public Guid Id { get; set; }
		public String RefreshToken { get; set; } = String.Empty;
		public DateTime RefreshTokenExpireTime { get; set; }
	}
}