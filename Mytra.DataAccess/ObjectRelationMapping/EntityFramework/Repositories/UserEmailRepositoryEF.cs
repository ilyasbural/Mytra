namespace Mytra.DataAccess
{
    public class UserEmailRepositoryEF : Core.BaseRepository<Core.UserEmail>, Core.IUserEmail
    {
        public UserEmailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}