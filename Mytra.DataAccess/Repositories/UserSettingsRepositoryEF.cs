namespace Mytra.DataAccess
{
	public class UserSettingsRepositoryEF : RepositoryBase<Core.UserSettings>, Core.IUserSettings
	{
		public UserSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}