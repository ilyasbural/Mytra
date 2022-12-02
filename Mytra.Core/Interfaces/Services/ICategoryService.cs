namespace Mytra.Core
{
    public interface ICategoryService
    {
        Task<CategoryResponse> AddAsync(CategoryInsertDataTransfer Model);
        Task<CategoryResponse> UpdateAsync(CategoryUpdateDataTransfer Model);
        Task<CategoryResponse> DeleteAsync(CategoryDeleteDataTransfer Model);
        Task<CategoryResponse> SelectAsync(CategorySelectDataTransfer Model);
    }
}