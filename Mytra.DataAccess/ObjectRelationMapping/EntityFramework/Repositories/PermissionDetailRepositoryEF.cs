namespace Mytra.DataAccess
{
    public class PermissionDetailRepositoryEF : Core.BaseRepository<Core.PermissionDetail>, Core.IPermissionDetail
    {
        public PermissionDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}