namespace Mytra.Core
{
    public interface IUserService
    {
        Task<Response<User>> InsertAsync(UserInsertDataTransfer Model);
        Task<Response<User>> UpdateAsync(UserUpdateDataTransfer Model);
        Task<Response<User>> DeleteAsync(UserDeleteDataTransfer Model);
        Task<Response<User>> SelectAsync(UserSelectDataTransfer Model);
        Task<Response<User>> AnySelectAsync(UserAnyDataTransfer Model);
    }
}