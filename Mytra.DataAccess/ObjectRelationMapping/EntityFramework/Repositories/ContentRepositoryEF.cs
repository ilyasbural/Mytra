namespace Mytra.DataAccess
{
    public class ContentRepositoryEF : RepositoryBase<Core.Content>, Core.IContentRepository
    {
        public ContentRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}