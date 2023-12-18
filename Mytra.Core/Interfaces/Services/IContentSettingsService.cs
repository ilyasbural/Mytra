namespace Mytra.Core
{
    public interface IContentSettingsService
    {
        Task<Response<ContentSettings>> InsertAsync(ContentSettingsInsertDataTransfer Model);
        Task<Response<ContentSettings>> UpdateAsync(ContentSettingsUpdateDataTransfer Model);
        Task<Response<ContentSettings>> DeleteAsync(ContentSettingsDeleteDataTransfer Model);
        Task<Response<ContentSettings>> SelectAsync(ContentSettingsSelectDataTransfer Model);
        Task<Response<ContentSettings>> AnySelectAsync(ContentSettingsAnyDataTransfer Model);
    }
}