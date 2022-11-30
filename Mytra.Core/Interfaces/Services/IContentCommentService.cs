namespace Mytra.Core
{
    public interface IContentCommentService
    {
        Task<ContentCommentResponse> AddAsync(ContentCommentInsertDataTransfer Model);
    }
}