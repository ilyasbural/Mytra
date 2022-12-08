namespace Mytra.Core
{
    public interface IUserService
    {
        Task<UserResponse> InsertAsync(UserInsertDataTransfer Model);
        Task<UserResponse> UpdateAsync(UserUpdateDataTransfer Model);
        Task<UserResponse> DeleteAsync(UserDeleteDataTransfer Model);
        Task<UserResponse> SelectAsync(UserSelectDataTransfer Model);
        Task<UserResponse> AnyAsync(UserAnyDataTransfer Model);
    }
}