namespace Mytra.Core
{
    public interface ICategoryService
    {
        Task<CategoryResponse> AddAsync(CategoryInsertDataTransfer Model);
    }
}