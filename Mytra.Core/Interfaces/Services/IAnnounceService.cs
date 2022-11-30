namespace Mytra.Core
{
    public interface IAnnounceService
    {
        Task<AnnounceResponse> AddAsync(AnnounceInsertDataTransfer Model);
        //Task<AnnounceResponse> UpdateAsync(AnnounceDataTransfer Model);
        //Task<AnnounceResponse> DeleteAsync(AnnounceDataTransfer Model);
        //Task<AnnounceResponse> SelectAsync(AnnounceDataTransfer Model);
        //Task<AnnounceResponse> AnyAsync(AnnounceDataTransfer Model);
    }
}