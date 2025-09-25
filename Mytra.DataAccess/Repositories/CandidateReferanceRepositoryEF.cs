namespace Mytra.DataAccess
{
	public class CandidateReferanceRepositoryEF : RepositoryBase<Core.CandidateReferance>, Core.ICandidateReferance
	{
		public CandidateReferanceRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}