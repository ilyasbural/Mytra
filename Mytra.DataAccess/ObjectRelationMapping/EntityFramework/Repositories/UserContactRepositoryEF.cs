namespace Mytra.DataAccess
{
    public class UserContactRepositoryEF : Core.BaseRepository<Core.UserContact>, Core.IUserContact
    {
        public UserContactRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}