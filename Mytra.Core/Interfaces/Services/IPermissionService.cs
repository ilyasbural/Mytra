namespace Mytra.Core
{
    public interface IPermissionService
    {
        Task<PermissionResponse> AddAsync(PermissionInsertDataTransfer Model);
        Task<PermissionResponse> UpdateAsync(PermissionUpdateDataTransfer Model);
    }
}