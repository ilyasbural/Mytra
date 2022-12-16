namespace Mytra.DataAccess
{
    public class PermissionDetailRepositoryEF : RepositoryBase<Core.PermissionDetail>, Core.IPermissionDetailRepository
    {
        public PermissionDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}