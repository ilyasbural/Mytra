namespace Mytra.Core
{
    public interface IManagementContactService
    {
        Task<Response<ManagementContact>> InsertAsync(ManagementContactInsertDataTransfer Model);
        Task<Response<ManagementContact>> UpdateAsync(ManagementContactUpdateDataTransfer Model);
        Task<Response<ManagementContact>> DeleteAsync(ManagementContactDeleteDataTransfer Model);
        Task<Response<ManagementContact>> SelectAsync(ManagementContactSelectDataTransfer Model);
        Task<Response<ManagementContact>> AnySelectAsync(ManagementContactAnyDataTransfer Model);
    }
}