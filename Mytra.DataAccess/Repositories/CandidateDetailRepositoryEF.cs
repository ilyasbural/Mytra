namespace Mytra.DataAccess
{
	public class CandidateDetailRepositoryEF : RepositoryBase<Core.CandidateDetail>, Core.ICandidateDetail
	{
		public CandidateDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}