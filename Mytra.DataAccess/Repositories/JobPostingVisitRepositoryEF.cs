namespace Mytra.DataAccess
{
	public class JobPostingVisitRepositoryEF : RepositoryBase<Core.JobPostingVisit>, Core.IJobPostingVisit
	{
		public JobPostingVisitRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}