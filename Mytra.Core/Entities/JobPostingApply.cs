namespace Mytra.Core
{
    public class JobPostingApply : Base<JobPostingApply>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public JobPostingApply()
		{
			
		}
	}
}