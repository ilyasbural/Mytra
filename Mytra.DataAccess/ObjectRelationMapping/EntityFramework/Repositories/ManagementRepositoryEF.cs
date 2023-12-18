namespace Mytra.DataAccess
{
    public class ManagementRepositoryEF : RepositoryBase<Core.Management>, Core.IManagementRepository
    {
        public ManagementRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}