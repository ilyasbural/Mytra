namespace Mytra.DataAccess
{
	public class JobPostingDetailRepositoryEF : RepositoryBase<Core.JobPostingDetail>, Core.IJobPostingDetail
	{
		public JobPostingDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}