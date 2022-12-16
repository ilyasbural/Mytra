namespace Mytra.DataAccess
{
    public class AnnounceRepositoryEF : RepositoryBase<Core.Announce>, Core.IAnnounceRepository
    {
        public AnnounceRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}