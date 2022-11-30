namespace Mytra.DataAccess
{
    public class UserEmailRepositoryEF : BaseRepository<Core.UserEmail>, Core.IUserEmailRepository
    {
        public UserEmailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}