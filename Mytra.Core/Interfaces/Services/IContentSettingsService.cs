namespace Mytra.Core
{
    public interface IContentSettingsService
    {
        Task<ContentSettingsResponse> AddAsync(ContentSettingsInsertDataTransfer Model);
        Task<ContentSettingsResponse> UpdateAsync(ContentSettingsUpdateDataTransfer Model);
        Task<ContentSettingsResponse> DeleteAsync(ContentSettingsDeleteDataTransfer Model);
        Task<ContentSettingsResponse> SelectAsync(ContentSettingsSelectDataTransfer Model);
        Task<ContentSettingsResponse> AnyAsync(ContentSettingsAnyDataTransfer Model);
    }
}