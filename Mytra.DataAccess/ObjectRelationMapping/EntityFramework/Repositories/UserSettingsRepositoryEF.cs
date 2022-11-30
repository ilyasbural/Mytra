namespace Mytra.DataAccess
{
    public class UserSettingsRepositoryEF : BaseRepository<Core.UserSettings>, Core.IUserSettingsRepository
    {
        public UserSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}