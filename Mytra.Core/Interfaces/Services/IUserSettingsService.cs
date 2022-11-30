namespace Mytra.Core
{
    public interface IUserSettingsService
    {
        Task<UserSettingsResponse> AddAsync(UserSettingsInsertDataTransfer Model);
    }
}