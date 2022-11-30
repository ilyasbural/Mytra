namespace Mytra.Core
{
    public interface IManagementContactService
    {
        Task<ManagementContactResponse> AddAsync(ManagementContactInsertDataTransfer Model);
    }
}