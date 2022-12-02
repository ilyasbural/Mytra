namespace Mytra.Core
{
    public interface IContentLikeService
    {
        Task<ContentLikeResponse> AddAsync(ContentLikeInsertDataTransfer Model);
        Task<ContentLikeResponse> UpdateAsync(ContentLikeUpdateDataTransfer Model);
        Task<ContentLikeResponse> DeleteAsync(ContentLikeDeleteDataTransfer Model);
    }
}