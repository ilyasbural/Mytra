namespace Mytra.DataAccess
{
    public class AnnounceDetailRepositoryEF : Core.BaseRepository<Core.AnnounceDetail>, Core.IAnnounceDetail
    {
        public AnnounceDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}