namespace Mytra.DataAccess
{
    public class ContentTypeRepositoryEF : Core.BaseRepository<Core.ContentType>, Core.IContentType
    {
        public ContentTypeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}