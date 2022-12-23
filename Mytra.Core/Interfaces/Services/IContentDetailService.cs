namespace Mytra.Core
{
    public interface IContentDetailService
    {
        Task<Response<ContentDetail>> InsertAsync(ContentDetailInsertDataTransfer Model);
        Task<Response<ContentDetail>> UpdateAsync(ContentDetailUpdateDataTransfer Model);
        Task<Response<ContentDetail>> DeleteAsync(ContentDetailDeleteDataTransfer Model);
        Task<Response<ContentDetail>> SelectAsync(ContentDetailSelectDataTransfer Model);
        Task<Response<ContentDetail>> AnySelectAsync(ContentDetailAnyDataTransfer Model);
    }
}