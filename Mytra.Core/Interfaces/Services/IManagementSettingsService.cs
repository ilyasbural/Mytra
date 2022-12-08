namespace Mytra.Core
{
    public interface IManagementSettingsService
    {
        Task<ManagementSettingsResponse> InsertAsync(ManagementSettingsInsertDataTransfer Model);
        Task<ManagementSettingsResponse> UpdateAsync(ManagementSettingsUpdateDataTransfer Model);
        Task<ManagementSettingsResponse> DeleteAsync(ManagementSettingsDeleteDataTransfer Model);
        Task<ManagementSettingsResponse> SelectAsync(ManagementSettingsSelectDataTransfer Model);
        Task<ManagementSettingsResponse> AnyAsync(ManagementSettingsAnyDataTransfer Model);
    }
}