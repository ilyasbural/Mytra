namespace Mytra.Business
{
    using Core;
    using System.Threading.Tasks;

    public partial class CategoryManager
    {
        public async Task<CategoryResponse> InsertAsync(CategoryInsertDataTransfer Model)
        {
            Category category = Mapper.Map<Category>(Model);
            category.Id = Guid.NewGuid();
            category.RegisterDate = DateTime.Now;
            category.UpdateDate = DateTime.Now;
            category.IsActive = true;

            await UnitOfWork.Category.InsertAsync(category);
            await UnitOfWork.SaveChangesAsync();

            return new CategoryResponse { Category = category };
        }
    }
}