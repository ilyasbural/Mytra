namespace Mytra.DataAccess
{
    public class ManagementRepositoryEF : Core.BaseRepository<Core.Management>, Core.IManagement
    {
        public ManagementRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}