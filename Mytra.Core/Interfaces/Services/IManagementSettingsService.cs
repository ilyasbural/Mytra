namespace Mytra.Core
{
    public interface IManagementSettingsService
    {
        Task<ManagementSettingsResponse> AddAsync(ManagementSettingsInsertDataTransfer Model);
    }
}