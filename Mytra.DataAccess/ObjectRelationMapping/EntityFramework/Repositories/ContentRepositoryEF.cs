namespace Mytra.DataAccess
{
    public class ContentRepositoryEF : BaseRepository<Core.Content>, Core.IContentRepository
    {
        public ContentRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}