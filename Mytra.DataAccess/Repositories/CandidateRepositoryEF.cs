namespace Mytra.DataAccess
{
	public class CandidateRepositoryEF : RepositoryBase<Core.Candidate>, Core.ICandidate
	{
		public CandidateRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}