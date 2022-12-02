namespace Mytra.Core
{
    public interface IContentCommentService
    {
        Task<ContentCommentResponse> AddAsync(ContentCommentInsertDataTransfer Model);
        Task<ContentCommentResponse> UpdateAsync(ContentCommentUpdateDataTransfer Model);
        Task<ContentCommentResponse> DeleteAsync(ContentCommentDeleteDataTransfer Model);
    }
}