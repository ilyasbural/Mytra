namespace Mytra.Utilize
{
	public class ManagerAuthenticationResponse : Response<ManagerAuthenticationResponse>
	{
		public String Name { get; set; } = String.Empty;
		public ManagerAuthenticationResponse() { }
	}
}