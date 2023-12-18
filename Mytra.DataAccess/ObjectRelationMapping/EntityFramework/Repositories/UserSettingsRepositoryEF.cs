namespace Mytra.DataAccess
{
    public class UserSettingsRepositoryEF : RepositoryBase<Core.UserSettings>, Core.IUserSettingsRepository
    {
        public UserSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}