namespace Mytra.Core
{
    public interface IManagementDetailService
    {
        Task<ManagementDetailResponse> AddAsync(ManagementDetailInsertDataTransfer Model);
        Task<ManagementDetailResponse> UpdateAsync(ManagementDetailUpdateDataTransfer Model);
        Task<ManagementDetailResponse> DeleteAsync(ManagementDetailDeleteDataTransfer Model);
        Task<ManagementDetailResponse> SelectAsync(ManagementDetailSelectDataTransfer Model);
        Task<ManagementDetailResponse> AnyAsync(ManagementDetailAnyDataTransfer Model);
    }
}