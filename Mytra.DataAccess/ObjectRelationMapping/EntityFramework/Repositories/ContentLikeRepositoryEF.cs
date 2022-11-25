namespace Mytra.DataAccess
{
    public class ContentLikeRepositoryEF : Core.BaseRepository<Core.ContentLike>, Core.IContentLike
    {
        public ContentLikeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}