namespace Mytra.Core
{
    public interface IContentDetailService
    {
        Task<ContentDetailResponse> AddAsync(ContentDetailInsertDataTransfer Model);
    }
}