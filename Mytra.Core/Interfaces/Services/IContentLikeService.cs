namespace Mytra.Core
{
    public interface IContentLikeService
    {
        Task<Response<ContentLike>> InsertAsync(ContentLikeInsertDataTransfer Model);
        Task<Response<ContentLike>> UpdateAsync(ContentLikeUpdateDataTransfer Model);
        Task<Response<ContentLike>> DeleteAsync(ContentLikeDeleteDataTransfer Model);
        Task<Response<ContentLike>> SelectAsync(ContentLikeSelectDataTransfer Model);
        Task<Response<ContentLike>> AnySelectAsync(ContentLikeAnyDataTransfer Model);
    }
}