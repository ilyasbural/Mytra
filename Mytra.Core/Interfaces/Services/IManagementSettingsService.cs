namespace Mytra.Core
{
    public interface IManagementSettingsService
    {
        Task<ManagementSettingsResponse> AddAsync(ManagementSettingsInsertDataTransfer Model);
        Task<ManagementSettingsResponse> UpdateAsync(ManagementSettingsUpdateDataTransfer Model);
        Task<ManagementSettingsResponse> DeleteAsync(ManagementSettingsDeleteDataTransfer Model);
    }
}