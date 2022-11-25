namespace Mytra.DataAccess
{
    public class ContentDetailRepositoryEF : Core.BaseRepository<Core.ContentDetail>, Core.IContentDetail
    {
        public ContentDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}