namespace Mytra.DataAccess
{
	public class CandidateAuthenticationRepositoryEF : RepositoryBase<Core.CandidateAuthentication>, Core.ICandidateAuthentication
	{
		public CandidateAuthenticationRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}