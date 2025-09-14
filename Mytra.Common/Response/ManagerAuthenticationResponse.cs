namespace Mytra.Common
{
	public class ManagerAuthenticationResponse : Response<ManagerAuthenticationResponse>
	{
		public String Name { get; set; } = String.Empty;
		public ManagerAuthenticationResponse() { }
	}
}