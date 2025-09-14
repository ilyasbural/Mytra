namespace Mytra.Common
{
	public class UserDetailResponse : Response<UserDetailResponse>
	{
		public String Name { get; set; } = String.Empty;
		public UserDetailResponse() { }
	}
}