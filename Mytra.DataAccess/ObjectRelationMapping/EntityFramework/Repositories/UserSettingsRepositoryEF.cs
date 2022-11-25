namespace Mytra.DataAccess
{
    public class UserSettingsRepositoryEF : Core.BaseRepository<Core.UserSettings>, Core.IUserSettings
    {
        public UserSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}