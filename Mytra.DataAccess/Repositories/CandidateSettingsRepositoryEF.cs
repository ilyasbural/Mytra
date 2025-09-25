namespace Mytra.DataAccess
{
	public class CandidateSettingsRepositoryEF : RepositoryBase<Core.CandidateSettings>, Core.ICandidateSettings
	{
		public CandidateSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}