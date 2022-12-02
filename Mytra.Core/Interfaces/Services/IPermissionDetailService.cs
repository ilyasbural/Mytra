namespace Mytra.Core
{
    public interface IPermissionDetailService
    {
        Task<PermissionDetailResponse> AddAsync(PermissionDetailInsertDataTransfer Model);
        Task<PermissionDetailResponse> UpdateAsync(PermissionDetailUpdateDataTransfer Model);
        Task<PermissionDetailResponse> DeleteAsync(PermissionDetailDeleteDataTransfer Model);
        Task<PermissionDetailResponse> SelectAsync(PermissionDetailSelectDataTransfer Model);
        Task<PermissionDetailResponse> AnyAsync(PermissionDetailAnyDataTransfer Model);
    }
}