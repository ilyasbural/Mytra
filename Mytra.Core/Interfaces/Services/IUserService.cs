namespace Mytra.Core
{
    public interface IUserService
    {
        Task<UserResponse> AddAsync(UserInsertDataTransfer Model);
        Task<UserResponse> UpdateAsync(UserUpdateDataTransfer Model);
        Task<UserResponse> DeleteAsync(UserDeleteDataTransfer Model);
    }
}