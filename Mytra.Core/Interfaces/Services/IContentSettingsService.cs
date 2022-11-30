namespace Mytra.Core
{
    public interface IContentSettingsService
    {
        Task<ContentSettingsResponse> AddAsync(ContentSettingsInsertDataTransfer Model);
    }
}