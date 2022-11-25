namespace Mytra.DataAccess
{
    public class ContentCommentRepositoryEF : Core.BaseRepository<Core.ContentComment>, Core.IContentComment
    {
        public ContentCommentRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}