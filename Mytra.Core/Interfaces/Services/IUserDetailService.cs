namespace Mytra.Core
{
    public interface IUserDetailService
    {
        Task<UserDetailResponse> AddAsync(UserDetailInsertDataTransfer Model);
        Task<UserDetailResponse> UpdateAsync(UserDetailUpdateDataTransfer Model);
        Task<UserDetailResponse> DeleteAsync(UserDetailDeleteDataTransfer Model);
    }
}