namespace Mytra.Core
{
    public interface IPermissionDetailService
    {
        Task<PermissionDetailResponse> AddAsync(PermissionDetailInsertDataTransfer Model);
    }
}