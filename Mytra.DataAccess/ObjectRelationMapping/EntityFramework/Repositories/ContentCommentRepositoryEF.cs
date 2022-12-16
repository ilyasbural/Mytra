namespace Mytra.DataAccess
{
    public class ContentCommentRepositoryEF : RepositoryBase<Core.ContentComment>, Core.IContentCommentRepository
    {
        public ContentCommentRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}