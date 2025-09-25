namespace Mytra.DataAccess
{
	public class JobPostingRepositoryEF : RepositoryBase<Core.JobPosting>, Core.IJobPosting
	{
		public JobPostingRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}