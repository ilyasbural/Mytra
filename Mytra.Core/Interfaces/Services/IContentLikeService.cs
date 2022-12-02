namespace Mytra.Core
{
    public interface IContentLikeService
    {
        Task<ContentLikeResponse> AddAsync(ContentLikeInsertDataTransfer Model);
        Task<ContentLikeResponse> UpdateAsync(ContentLikeUpdateDataTransfer Model);
        Task<ContentLikeResponse> DeleteAsync(ContentLikeDeleteDataTransfer Model);
        Task<ContentLikeResponse> SelectAsync(ContentLikeSelectDataTransfer Model);
        Task<ContentLikeResponse> AnyAsync(ContentLikeAnyDataTransfer Model);
    }
}