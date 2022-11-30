namespace Mytra.Core
{
    public interface IAnnounceDetailService
    {
        Task<AnnounceDetailResponse> AddAsync(AnnounceDetailInsertDataTransfer Model);
    }
}