namespace Mytra.DataAccess
{
    public class ContentRepositoryEF : Core.BaseRepository<Core.Content>, Core.IContent
    {
        public ContentRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}