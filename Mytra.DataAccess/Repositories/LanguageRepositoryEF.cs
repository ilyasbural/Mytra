namespace Mytra.DataAccess
{
	public class LanguageRepositoryEF : RepositoryBase<Core.Language>, Core.ILanguage
	{
		public LanguageRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}