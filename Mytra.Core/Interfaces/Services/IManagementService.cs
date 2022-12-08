namespace Mytra.Core
{
    public interface IManagementService
    {
        Task<ManagementResponse> InsertAsync(ManagementInsertDataTransfer Model);
        Task<ManagementResponse> UpdateAsync(ManagementUpdateDataTransfer Model);
        Task<ManagementResponse> DeleteAsync(ManagementDeleteDataTransfer Model);
        Task<ManagementResponse> SelectAsync(ManagementSelectDataTransfer Model);
        Task<ManagementResponse> AnyAsync(ManagementAnyDataTransfer Model);
    }
}