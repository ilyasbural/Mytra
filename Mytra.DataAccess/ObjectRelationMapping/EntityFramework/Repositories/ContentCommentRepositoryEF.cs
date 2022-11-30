namespace Mytra.DataAccess
{
    public class ContentCommentRepositoryEF : BaseRepository<Core.ContentComment>, Core.IContentCommentRepository
    {
        public ContentCommentRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}