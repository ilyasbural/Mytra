namespace Mytra.DataAccess
{
	public class CandidateLanguageRepositoryEF : RepositoryBase<Core.CandidateLanguage>, Core.ICandidateLanguage
	{
		public CandidateLanguageRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}