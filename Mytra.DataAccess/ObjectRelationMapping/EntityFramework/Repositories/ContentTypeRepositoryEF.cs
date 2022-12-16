namespace Mytra.DataAccess
{
    public class ContentTypeRepositoryEF : RepositoryBase<Core.ContentType>, Core.IContentTypeRepository
    {
        public ContentTypeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}