namespace Mytra.DataAccess
{
	public class CandidateContactRepositoryEF : RepositoryBase<Core.CandidateContact>, Core.ICandidateContact
	{
		public CandidateContactRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}