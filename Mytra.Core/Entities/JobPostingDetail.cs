namespace Mytra.Core
{
    public class JobPostingDetail : Base<JobPostingDetail>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public JobPostingDetail()
		{
			
		}
	}
}