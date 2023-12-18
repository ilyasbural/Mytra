namespace Mytra.DataAccess
{
    public class ContentDetailRepositoryEF : RepositoryBase<Core.ContentDetail>, Core.IContentDetailRepository
    {
        public ContentDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}