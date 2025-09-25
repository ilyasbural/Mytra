namespace Mytra.Utilize
{
	public class JobPostingDetailResponse : Response<JobPostingDetailResponse>
	{
		public String Name { get; set; } = String.Empty;
		public JobPostingDetailResponse() { }
	}
}