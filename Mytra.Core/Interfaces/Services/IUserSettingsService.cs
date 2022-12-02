namespace Mytra.Core
{
    public interface IUserSettingsService
    {
        Task<UserSettingsResponse> AddAsync(UserSettingsInsertDataTransfer Model);
        Task<UserSettingsResponse> UpdateAsync(UserSettingsUpdateDataTransfer Model);
        Task<UserSettingsResponse> DeleteAsync(UserSettingsDeleteDataTransfer Model);
    }
}