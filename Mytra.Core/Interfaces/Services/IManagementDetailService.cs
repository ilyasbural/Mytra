namespace Mytra.Core
{
    public interface IManagementDetailService
    {
        Task<Response<ManagementDetail>> InsertAsync(ManagementDetailInsertDataTransfer Model);
        Task<Response<ManagementDetail>> UpdateAsync(ManagementDetailUpdateDataTransfer Model);
        Task<Response<ManagementDetail>> DeleteAsync(ManagementDetailDeleteDataTransfer Model);
        Task<Response<ManagementDetail>> SelectAsync(ManagementDetailSelectDataTransfer Model);
        Task<Response<ManagementDetail>> AnySelectAsync(ManagementDetailAnyDataTransfer Model);
    }
}