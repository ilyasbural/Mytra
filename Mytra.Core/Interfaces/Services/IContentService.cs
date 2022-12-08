namespace Mytra.Core
{
    public interface IContentService
    {
        Task<ContentResponse> InsertAsync(ContentInsertDataTransfer Model);
        Task<ContentResponse> UpdateAsync(ContentUpdateDataTransfer Model);
        Task<ContentResponse> DeleteAsync(ContentDeleteDataTransfer Model);
        Task<ContentResponse> SelectAsync(ContentSelectDataTransfer Model);
        Task<ContentResponse> AnyAsync(ContentAnyDataTransfer Model);
    }
}