namespace Mytra.Core
{
    public interface IContentLikeService
    {
        Task<ContentLikeResponse> AddAsync(ContentLikeInsertDataTransfer Model);
    }
}