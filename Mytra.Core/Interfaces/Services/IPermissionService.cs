namespace Mytra.Core
{
    public interface IPermissionService
    {
        Task<PermissionResponse> AddAsync(PermissionInsertDataTransfer Model);
    }
}