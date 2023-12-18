namespace Mytra.DataAccess
{
    public class UserDetailRepositoryEF : RepositoryBase<Core.UserDetail>, Core.IUserDetailRepository
    {
        public UserDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}