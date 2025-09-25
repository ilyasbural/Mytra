namespace Mytra.Core
{
    public class UserAuthentication : Base<UserAuthentication>, IEntity
    {
		//public User User { get; set; } = new User();
		public String RefreshToken { get; set; } = String.Empty;
		public DateTime RefreshTokenExpireTime { get; set; }

		public UserAuthentication()
		{
			
		}
	}
}