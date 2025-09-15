namespace Mytra.Common
{
	public class UserResponse : Response<UserResponse>
	{
		public String Email { get; set; } = String.Empty;
		public UserResponse() { }
	}
}