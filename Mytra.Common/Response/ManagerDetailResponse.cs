namespace Mytra.Common
{
	public class ManagerDetailResponse : Response<ManagerDetailResponse>
	{
		public String Name { get; set; } = String.Empty;
		public ManagerDetailResponse() { }
	}
}