namespace Mytra.Core
{
    public interface IPermissionService
    {
        Task<Response<Permission>> InsertAsync(PermissionInsertDataTransfer Model);
        Task<Response<Permission>> UpdateAsync(PermissionUpdateDataTransfer Model);
        Task<Response<Permission>> DeleteAsync(PermissionDeleteDataTransfer Model);
        Task<Response<Permission>> SelectAsync(PermissionSelectDataTransfer Model);
        Task<Response<Permission>> AnySelectAsync(PermissionAnyDataTransfer Model);
    }
}