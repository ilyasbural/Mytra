namespace Mytra.Core
{
    public interface IUserSettingsService
    {
        Task<UserSettingsResponse> InsertAsync(UserSettingsInsertDataTransfer Model);
        Task<UserSettingsResponse> UpdateAsync(UserSettingsUpdateDataTransfer Model);
        Task<UserSettingsResponse> DeleteAsync(UserSettingsDeleteDataTransfer Model);
        Task<UserSettingsResponse> SelectAsync(UserSettingsSelectDataTransfer Model);
        Task<UserSettingsResponse> AnyAsync(UserSettingsAnyDataTransfer Model);
    }
}