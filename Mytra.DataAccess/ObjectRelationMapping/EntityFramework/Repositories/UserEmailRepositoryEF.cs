namespace Mytra.DataAccess
{
    public class UserEmailRepositoryEF : RepositoryBase<Core.UserEmail>, Core.IUserEmailRepository
    {
        public UserEmailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}