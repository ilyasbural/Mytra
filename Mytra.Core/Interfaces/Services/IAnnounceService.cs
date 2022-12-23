namespace Mytra.Core
{
    public interface IAnnounceService
    {
        Task<Response<Announce>> InsertAsync(AnnounceInsertDataTransfer Model);
        Task<Response<Announce>> UpdateAsync(AnnounceUpdateDataTransfer Model);
        Task<Response<Announce>> DeleteAsync(AnnounceDeleteDataTransfer Model);
        Task<Response<Announce>> SelectAsync(AnnounceSelectDataTransfer Model);
        Task<Response<Announce>> AnySelectAsync(AnnounceAnyDataTransfer Model);
    }
}