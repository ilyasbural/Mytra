namespace Mytra.DataAccess
{
    public class CategoryRepositoryEF : RepositoryBase<Core.Category>, Core.ICategoryRepository
    {
        public CategoryRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}