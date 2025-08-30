namespace Mytra.Core
{
    public class JobPosting : Base<JobPosting>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public JobPosting()
		{
			
		}
	}
}