namespace Mytra.Core
{
    public interface IManagementService
    {
        Task<ManagementResponse> AddAsync(ManagementInsertDataTransfer Model);
        Task<ManagementResponse> UpdateAsync(ManagementUpdateDataTransfer Model);
    }
}