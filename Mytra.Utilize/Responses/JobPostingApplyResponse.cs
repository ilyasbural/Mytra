namespace Mytra.Utilize
{
	public class JobPostingApplyResponse : Response<JobPostingApplyResponse>
	{
		public String Name { get; set; } = String.Empty;
		public JobPostingApplyResponse() { }
	}
}