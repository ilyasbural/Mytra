namespace Mytra.Core
{
    public interface IAnnounceDetailService
    {
        Task<AnnounceDetailResponse> AddAsync(AnnounceDetailInsertDataTransfer Model);
        Task<AnnounceDetailResponse> UpdateAsync(AnnounceDetailUpdateDataTransfer Model);
        Task<AnnounceDetailResponse> DeleteAsync(AnnounceDetailDeleteDataTransfer Model);
        Task<AnnounceDetailResponse> SelectAsync(AnnounceDetailSelectDataTransfer Model);
        Task<AnnounceDetailResponse> AnyAsync(AnnounceDetailAnyDataTransfer Model);
    }
}