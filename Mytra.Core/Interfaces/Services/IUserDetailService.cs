namespace Mytra.Core
{
    public interface IUserDetailService
    {
        Task<UserDetailResponse> AddAsync(UserDetailInsertDataTransfer Model);
    }
}