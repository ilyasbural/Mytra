namespace Mytra.Utilize
{
	public class UserSettingsResponse : Response<UserSettingsResponse>
	{
		public String Name { get; set; } = String.Empty;
		public UserSettingsResponse() { }
	}
}