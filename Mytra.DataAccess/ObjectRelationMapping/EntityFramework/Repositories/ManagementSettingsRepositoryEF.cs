namespace Mytra.DataAccess
{
    public class ManagementSettingsRepositoryEF : BaseRepository<Core.ManagementSettings>, Core.IManagementSettingsRepository
    {
        public ManagementSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}