namespace Mytra.Core
{
    public interface IContentDetailService
    {
        Task<ContentDetailResponse> InsertAsync(ContentDetailInsertDataTransfer Model);
        Task<ContentDetailResponse> UpdateAsync(ContentDetailUpdateDataTransfer Model);
        Task<ContentDetailResponse> DeleteAsync(ContentDetailDeleteDataTransfer Model);
        Task<ContentDetailResponse> SelectAsync(ContentDetailSelectDataTransfer Model);
        Task<ContentDetailResponse> AnyAsync(ContentDetailAnyDataTransfer Model);
    }
}