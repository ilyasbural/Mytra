namespace Mytra.DataAccess
{
    public class UserContactRepositoryEF : BaseRepository<Core.UserContact>, Core.IUserContactRepository
    {
        public UserContactRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}