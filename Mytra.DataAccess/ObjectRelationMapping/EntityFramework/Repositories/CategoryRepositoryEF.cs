namespace Mytra.DataAccess
{
    public class CategoryRepositoryEF : BaseRepository<Core.Category>, Core.ICategoryRepository
    {
        public CategoryRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}