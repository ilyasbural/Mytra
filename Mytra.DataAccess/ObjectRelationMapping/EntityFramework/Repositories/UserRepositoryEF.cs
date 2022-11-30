namespace Mytra.DataAccess
{
    public class UserRepositoryEF : BaseRepository<Core.User>, Core.IUserRepository
    {
        public UserRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}