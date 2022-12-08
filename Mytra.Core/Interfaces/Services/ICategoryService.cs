namespace Mytra.Core
{
    public interface ICategoryService
    {
        Task<CategoryResponse> InsertAsync(CategoryInsertDataTransfer Model);
        Task<CategoryResponse> UpdateAsync(CategoryUpdateDataTransfer Model);
        Task<CategoryResponse> DeleteAsync(CategoryDeleteDataTransfer Model);
        Task<CategoryResponse> SelectAsync(CategorySelectDataTransfer Model);
        Task<CategoryResponse> AnyAsync(CategoryAnyDataTransfer Model);
    }
}