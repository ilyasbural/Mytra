namespace Mytra.DataAccess
{
    public class CategoryRepositoryEF : Core.BaseRepository<Core.Category>, Core.ICategory
    {
        public CategoryRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}