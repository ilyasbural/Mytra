namespace Mytra.DataAccess
{
    public class AnnounceRepositoryEF : BaseRepository<Core.Announce>, Core.IAnnounceRepository
    {
        public AnnounceRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}