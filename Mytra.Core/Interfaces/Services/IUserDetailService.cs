namespace Mytra.Core
{
    public interface IUserDetailService
    {
        Task<UserDetailResponse> InsertAsync(UserDetailInsertDataTransfer Model);
        Task<UserDetailResponse> UpdateAsync(UserDetailUpdateDataTransfer Model);
        Task<UserDetailResponse> DeleteAsync(UserDetailDeleteDataTransfer Model);
        Task<UserDetailResponse> SelectAsync(UserDetailSelectDataTransfer Model);
        Task<UserDetailResponse> AnyAsync(UserDetailAnyDataTransfer Model);
    }
}