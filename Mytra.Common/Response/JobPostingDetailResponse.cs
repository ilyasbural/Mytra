namespace Mytra.Common
{
	public class JobPostingDetailResponse : Response<JobPostingDetailResponse>
	{
		public String Name { get; set; } = String.Empty;
		public JobPostingDetailResponse() { }
	}
}