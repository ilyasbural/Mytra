namespace Mytra.Core
{
    public interface IPermissionDetailService
    {
        Task<Response<PermissionDetail>> InsertAsync(PermissionDetailInsertDataTransfer Model);
        Task<Response<PermissionDetail>> UpdateAsync(PermissionDetailUpdateDataTransfer Model);
        Task<Response<PermissionDetail>> DeleteAsync(PermissionDetailDeleteDataTransfer Model);
        Task<Response<PermissionDetail>> SelectAsync(PermissionDetailSelectDataTransfer Model);
        Task<Response<PermissionDetail>> AnySelectAsync(PermissionDetailAnyDataTransfer Model);
    }
}