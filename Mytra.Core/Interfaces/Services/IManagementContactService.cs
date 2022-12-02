namespace Mytra.Core
{
    public interface IManagementContactService
    {
        Task<ManagementContactResponse> AddAsync(ManagementContactInsertDataTransfer Model);
        Task<ManagementContactResponse> UpdateAsync(ManagementContactUpdateDataTransfer Model);
        Task<ManagementContactResponse> DeleteAsync(ManagementContactDeleteDataTransfer Model);
    }
}