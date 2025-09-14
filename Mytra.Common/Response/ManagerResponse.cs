namespace Mytra.Common
{
	public class ManagerResponse : Response<ManagerResponse>
	{
		public String Name { get; set; } = String.Empty;
		public ManagerResponse() { }
	}
}