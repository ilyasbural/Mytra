namespace Mytra.Core
{
    public class JobPostingVisit : Base<JobPostingVisit>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public JobPostingVisit()
		{
			
		}
	}
}