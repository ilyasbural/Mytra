namespace Mytra.DataAccess
{
    public class UserDetailRepositoryEF : Core.BaseRepository<Core.UserDetail>, Core.IUserDetail
    {
        public UserDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}