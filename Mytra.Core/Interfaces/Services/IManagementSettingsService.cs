namespace Mytra.Core
{
    public interface IManagementSettingsService
    {
        Task<Response<ManagementSettings>> InsertAsync(ManagementSettingsInsertDataTransfer Model);
        Task<Response<ManagementSettings>> UpdateAsync(ManagementSettingsUpdateDataTransfer Model);
        Task<Response<ManagementSettings>> DeleteAsync(ManagementSettingsDeleteDataTransfer Model);
        Task<Response<ManagementSettings>> SelectAsync(ManagementSettingsSelectDataTransfer Model);
        Task<Response<ManagementSettings>> AnySelectAsync(ManagementSettingsAnyDataTransfer Model);
    }
}