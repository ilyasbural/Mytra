namespace Mytra.DataAccess
{
    public class UserContactRepositoryEF : RepositoryBase<Core.UserContact>, Core.IUserContactRepository
    {
        public UserContactRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}