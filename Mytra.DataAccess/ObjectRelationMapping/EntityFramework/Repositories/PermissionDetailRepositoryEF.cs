namespace Mytra.DataAccess
{
    public class PermissionDetailRepositoryEF : BaseRepository<Core.PermissionDetail>, Core.IPermissionDetailRepository
    {
        public PermissionDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}