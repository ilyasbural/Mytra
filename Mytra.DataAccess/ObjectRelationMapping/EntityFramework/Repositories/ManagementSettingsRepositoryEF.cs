namespace Mytra.DataAccess
{
    public class ManagementSettingsRepositoryEF : RepositoryBase<Core.ManagementSettings>, Core.IManagementSettingsRepository
    {
        public ManagementSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}