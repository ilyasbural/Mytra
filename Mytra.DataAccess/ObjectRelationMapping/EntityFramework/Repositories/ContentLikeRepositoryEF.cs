namespace Mytra.DataAccess
{
    public class ContentLikeRepositoryEF : BaseRepository<Core.ContentLike>, Core.IContentLikeRepository
    {
        public ContentLikeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}