namespace Mytra.Core
{
    public interface IManagementDetailService
    {
        Task<ManagementDetailResponse> AddAsync(ManagementDetailInsertDataTransfer Model);
        Task<ManagementDetailResponse> UpdateAsync(ManagementDetailUpdateDataTransfer Model);
    }
}