namespace Mytra.Core
{
    public interface IManagementDetailService
    {
        Task<ManagementDetailResponse> AddAsync(ManagementDetailInsertDataTransfer Model);
    }
}