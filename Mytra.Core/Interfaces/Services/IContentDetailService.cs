namespace Mytra.Core
{
    public interface IContentDetailService
    {
        Task<ContentDetailResponse> AddAsync(ContentDetailInsertDataTransfer Model);
        Task<ContentDetailResponse> UpdateAsync(ContentDetailUpdateDataTransfer Model);
        Task<ContentDetailResponse> DeleteAsync(ContentDetailDeleteDataTransfer Model);
    }
}