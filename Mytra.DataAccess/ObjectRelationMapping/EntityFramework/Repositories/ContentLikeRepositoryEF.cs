namespace Mytra.DataAccess
{
    public class ContentLikeRepositoryEF : RepositoryBase<Core.ContentLike>, Core.IContentLikeRepository
    {
        public ContentLikeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}