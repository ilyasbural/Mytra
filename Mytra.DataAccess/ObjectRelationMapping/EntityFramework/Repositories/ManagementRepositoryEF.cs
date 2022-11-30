namespace Mytra.DataAccess
{
    public class ManagementRepositoryEF : BaseRepository<Core.Management>, Core.IManagementRepository
    {
        public ManagementRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}