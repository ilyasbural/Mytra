namespace Mytra.Utilize
{
	public class UserResponse : Response<UserResponse>
	{
		public String Email { get; set; } = String.Empty;
		public UserResponse() { }
	}
}