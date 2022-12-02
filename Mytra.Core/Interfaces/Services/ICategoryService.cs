namespace Mytra.Core
{
    public interface ICategoryService
    {
        Task<CategoryResponse> AddAsync(CategoryInsertDataTransfer Model);
        Task<CategoryResponse> UpdateAsync(CategoryUpdateDataTransfer Model);
    }
}