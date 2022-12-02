namespace Mytra.Core
{
    public interface IPermissionService
    {
        Task<PermissionResponse> AddAsync(PermissionInsertDataTransfer Model);
        Task<PermissionResponse> UpdateAsync(PermissionUpdateDataTransfer Model);
        Task<PermissionResponse> DeleteAsync(PermissionDeleteDataTransfer Model);
        Task<PermissionResponse> SelectAsync(PermissionSelectDataTransfer Model);
    }
}