namespace Mytra.Core
{
    public interface ICategoryService
    {
        Task<Response<Category>> InsertAsync(CategoryInsertDataTransfer Model);
        Task<Response<Category>> UpdateAsync(CategoryUpdateDataTransfer Model);
        Task<Response<Category>> DeleteAsync(CategoryDeleteDataTransfer Model);
        Task<Response<Category>> SelectAsync(CategorySelectDataTransfer Model);
        Task<Response<Category>> AnySelectAsync(CategoryAnyDataTransfer Model);
    }
}