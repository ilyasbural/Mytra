namespace Mytra.DataAccess
{
    public class PermissionRepositoryEF : RepositoryBase<Core.Permission>, Core.IPermissionRepository
    {
        public PermissionRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}