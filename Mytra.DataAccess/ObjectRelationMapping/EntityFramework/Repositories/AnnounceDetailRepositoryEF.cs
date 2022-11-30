namespace Mytra.DataAccess
{
    using Core;

    public class AnnounceDetailRepositoryEF : BaseRepository<AnnounceDetail>, IAnnounceDetailRepository
    {
        public AnnounceDetailRepositoryEF(MytraContext dbContext) : base(dbContext)
        {

        }
    }
}