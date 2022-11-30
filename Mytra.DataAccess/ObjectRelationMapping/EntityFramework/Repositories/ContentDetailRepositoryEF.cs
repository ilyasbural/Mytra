namespace Mytra.DataAccess
{
    public class ContentDetailRepositoryEF : BaseRepository<Core.ContentDetail>, Core.IContentDetailRepository
    {
        public ContentDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}