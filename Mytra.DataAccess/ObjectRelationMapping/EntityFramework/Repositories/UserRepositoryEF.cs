namespace Mytra.DataAccess
{
    public class UserRepositoryEF : RepositoryBase<Core.User>, Core.IUserRepository
    {
        public UserRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}