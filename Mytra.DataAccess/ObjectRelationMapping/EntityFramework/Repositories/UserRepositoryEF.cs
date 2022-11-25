namespace Mytra.DataAccess
{
    public class UserRepositoryEF : Core.BaseRepository<Core.User>, Core.IUser
    {
        public UserRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}