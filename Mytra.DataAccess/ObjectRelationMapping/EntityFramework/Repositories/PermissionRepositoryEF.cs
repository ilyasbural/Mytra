namespace Mytra.DataAccess
{
    public class PermissionRepositoryEF : Core.BaseRepository<Core.Permission>, Core.IPermission
    {
        public PermissionRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}