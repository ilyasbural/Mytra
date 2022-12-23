namespace Mytra.Core
{
    public interface IUserSettingsService
    {
        Task<Response<UserSettings>> InsertAsync(UserSettingsInsertDataTransfer Model);
        Task<Response<UserSettings>> UpdateAsync(UserSettingsUpdateDataTransfer Model);
        Task<Response<UserSettings>> DeleteAsync(UserSettingsDeleteDataTransfer Model);
        Task<Response<UserSettings>> SelectAsync(UserSettingsSelectDataTransfer Model);
        Task<Response<UserSettings>> AnySelectAsync(UserSettingsAnyDataTransfer Model);
    }
}