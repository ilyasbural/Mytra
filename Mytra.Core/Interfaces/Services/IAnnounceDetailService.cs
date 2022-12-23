namespace Mytra.Core
{
    public interface IAnnounceDetailService
    {
        Task<Response<AnnounceDetail>> InsertAsync(AnnounceDetailInsertDataTransfer Model);
        Task<Response<AnnounceDetail>> UpdateAsync(AnnounceDetailUpdateDataTransfer Model);
        Task<Response<AnnounceDetail>> DeleteAsync(AnnounceDetailDeleteDataTransfer Model);
        Task<Response<AnnounceDetail>> SelectAsync(AnnounceDetailSelectDataTransfer Model);
        Task<Response<AnnounceDetail>> AnyAsync(AnnounceDetailAnyDataTransfer Model);
    }
}