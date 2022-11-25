namespace Mytra.DataAccess
{
    public class ManagementSettingsRepositoryEF : Core.BaseRepository<Core.ManagementSettings>, Core.IManagementSettings
    {
        public ManagementSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}