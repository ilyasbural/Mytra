namespace Mytra.Core
{
    public interface IManagementService
    {
        Task<Response<Management>> InsertAsync(ManagementInsertDataTransfer Model);
        Task<Response<Management>> UpdateAsync(ManagementUpdateDataTransfer Model);
        Task<Response<Management>> DeleteAsync(ManagementDeleteDataTransfer Model);
        Task<Response<Management>> SelectAsync(ManagementSelectDataTransfer Model);
        Task<Response<Management>> AnySelectAsync(ManagementAnyDataTransfer Model);
    }
}