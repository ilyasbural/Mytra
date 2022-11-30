namespace Mytra.DataAccess
{
    public class PermissionRepositoryEF : BaseRepository<Core.Permission>, Core.IPermissionRepository
    {
        public PermissionRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}