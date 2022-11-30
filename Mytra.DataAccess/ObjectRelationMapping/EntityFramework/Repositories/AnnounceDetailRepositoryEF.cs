namespace Mytra.DataAccess
{
    public class AnnounceDetailRepositoryEF : BaseRepository<Core.AnnounceDetail>, Core.IAnnounceDetailRepository
    {
        public AnnounceDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}