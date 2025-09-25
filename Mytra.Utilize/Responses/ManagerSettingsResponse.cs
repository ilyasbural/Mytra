namespace Mytra.Utilize
{
	public class ManagerSettingsResponse : Response<ManagerSettingsResponse>
	{
		public String Name { get; set; } = String.Empty;
		public ManagerSettingsResponse() { }
	}
}