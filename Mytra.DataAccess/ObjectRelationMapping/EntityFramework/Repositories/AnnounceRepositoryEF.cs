namespace Mytra.DataAccess
{
    public class AnnounceRepositoryEF : Core.BaseRepository<Core.Announce>, Core.IAnnounce
    {
        public AnnounceRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}