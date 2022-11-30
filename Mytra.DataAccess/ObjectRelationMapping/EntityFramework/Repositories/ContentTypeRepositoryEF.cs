namespace Mytra.DataAccess
{
    public class ContentTypeRepositoryEF : BaseRepository<Core.ContentType>, Core.IContentTypeRepository
    {
        public ContentTypeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}