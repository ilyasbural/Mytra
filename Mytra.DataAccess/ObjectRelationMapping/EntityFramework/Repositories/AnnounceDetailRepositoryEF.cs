namespace Mytra.DataAccess
{
    public class AnnounceDetailRepositoryEF : RepositoryBase<Core.AnnounceDetail>, Core.IAnnounceDetailRepository
    {
        public AnnounceDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}