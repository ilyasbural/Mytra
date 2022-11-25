namespace Mytra.DataAccess
{
    public class ManagementDetailRepositoryEF : Core.BaseRepository<Core.ManagementDetail>, Core.IManagementDetail
    {
        public ManagementDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}