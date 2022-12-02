namespace Mytra.Core
{
    public interface IAnnounceService
    {
        Task<AnnounceResponse> AddAsync(AnnounceInsertDataTransfer Model);
        Task<AnnounceResponse> UpdateAsync(AnnounceUpdateDataTransfer Model);
        Task<AnnounceResponse> DeleteAsync(AnnounceDeleteDataTransfer Model);
        Task<AnnounceResponse> SelectAsync(AnnounceSelectDataTransfer Model);
        Task<AnnounceResponse> AnyAsync(AnnounceAnyDataTransfer Model);
    }
}