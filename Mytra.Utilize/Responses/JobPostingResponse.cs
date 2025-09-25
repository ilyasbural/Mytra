namespace Mytra.Utilize
{
	public class JobPostingResponse : Response<JobPostingResponse>
	{
		public String Name { get; set; } = String.Empty;
		public JobPostingResponse() { }
	}
}