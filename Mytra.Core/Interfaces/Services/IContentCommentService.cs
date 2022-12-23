namespace Mytra.Core
{
    public interface IContentCommentService
    {
        Task<Response<ContentComment>> InsertAsync(ContentCommentInsertDataTransfer Model);
        Task<Response<ContentComment>> UpdateAsync(ContentCommentUpdateDataTransfer Model);
        Task<Response<ContentComment>> DeleteAsync(ContentCommentDeleteDataTransfer Model);
        Task<Response<ContentComment>> SelectAsync(ContentCommentSelectDataTransfer Model);
        Task<Response<ContentComment>> AnySelectAsync(ContentCommentAnyDataTransfer Model);
    }
}