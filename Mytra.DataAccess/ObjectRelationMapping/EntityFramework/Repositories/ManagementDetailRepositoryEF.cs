namespace Mytra.DataAccess
{
    public class ManagementDetailRepositoryEF : BaseRepository<Core.ManagementDetail>, Core.IManagementDetailRepository
    {
        public ManagementDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}