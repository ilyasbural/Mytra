namespace Mytra.Common
{
	public class UserResponse : Response<UserResponse>
	{
		public String Name { get; set; } = String.Empty;
		public UserResponse() { }
	}
}