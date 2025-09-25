namespace Mytra.DataAccess
{
	public class ManagerSettingsRepositoryEF : RepositoryBase<Core.ManagerSettings>, Core.IManagerSettings
	{
		public ManagerSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}