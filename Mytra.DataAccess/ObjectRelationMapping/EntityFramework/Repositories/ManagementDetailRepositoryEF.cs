namespace Mytra.DataAccess
{
    public class ManagementDetailRepositoryEF : RepositoryBase<Core.ManagementDetail>, Core.IManagementDetailRepository
    {
        public ManagementDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}