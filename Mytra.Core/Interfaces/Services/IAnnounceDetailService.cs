namespace Mytra.Core
{
    public interface IAnnounceDetailService
    {
        Task<Response<AnnounceDetail>> InsertAsync(AnnounceDetailInsertDataTransfer Model);
        Task<Response<AnnounceDetail>> UpdateAsync(AnnounceDetailUpdateDataTransfer Model);
        Task<Response<AnnounceDetail>> DeleteAsync(AnnounceDetailDeleteDataTransfer Model);
        Task<Response<AnnounceDetail>> SelectAsync(AnnounceDetailSelectDataTransfer Model);
        Task<Response<AnnounceDetail>> AnySelectAsync(AnnounceDetailAnyDataTransfer Model);
        Response<AnnounceDetail> Insert(AnnounceDetailInsertDataTransfer Model);
        Response<AnnounceDetail> Update(AnnounceDetailUpdateDataTransfer Model);
        Response<AnnounceDetail> Delete(AnnounceDetailDeleteDataTransfer Model);
        Response<AnnounceDetail> Select(AnnounceDetailSelectDataTransfer Model);
        Response<AnnounceDetail> AnySelect(AnnounceDetailAnyDataTransfer Model);
    }
}