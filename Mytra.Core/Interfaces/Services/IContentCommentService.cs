namespace Mytra.Core
{
    public interface IContentCommentService
    {
        Task<ContentCommentResponse> InsertAsync(ContentCommentInsertDataTransfer Model);
        Task<ContentCommentResponse> UpdateAsync(ContentCommentUpdateDataTransfer Model);
        Task<ContentCommentResponse> DeleteAsync(ContentCommentDeleteDataTransfer Model);
        Task<ContentCommentResponse> SelectAsync(ContentCommentSelectDataTransfer Model);
        Task<ContentCommentResponse> AnyAsync(ContentCommentAnyDataTransfer Model);
    }
}