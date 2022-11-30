namespace Mytra.Core
{
    public interface IUserService
    {
        Task<UserResponse> AddAsync(UserInsertDataTransfer Model);
    }
}