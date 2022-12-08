namespace Mytra.Core
{
    public interface IPermissionService
    {
        Task<PermissionResponse> InsertAsync(PermissionInsertDataTransfer Model);
        Task<PermissionResponse> UpdateAsync(PermissionUpdateDataTransfer Model);
        Task<PermissionResponse> DeleteAsync(PermissionDeleteDataTransfer Model);
        Task<PermissionResponse> SelectAsync(PermissionSelectDataTransfer Model);
        Task<PermissionResponse> AnyAsync(PermissionAnyDataTransfer Model);
    }
}