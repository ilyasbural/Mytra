namespace Mytra.Core
{
    public interface IContentService
    {
        Task<Response<Content>> InsertAsync(ContentInsertDataTransfer Model);
        Task<Response<Content>> UpdateAsync(ContentUpdateDataTransfer Model);
        Task<Response<Content>> DeleteAsync(ContentDeleteDataTransfer Model);
        Task<Response<Content>> SelectAsync(ContentSelectDataTransfer Model);
        Task<Response<Content>> AnySelectAsync(ContentAnyDataTransfer Model);
    }
}