namespace Mytra.Core
{
    public interface IUserDetailService
    {
        Task<Response<UserDetail>> InsertAsync(UserDetailInsertDataTransfer Model);
        Task<Response<UserDetail>> UpdateAsync(UserDetailUpdateDataTransfer Model);
        Task<Response<UserDetail>> DeleteAsync(UserDetailDeleteDataTransfer Model);
        Task<Response<UserDetail>> SelectAsync(UserDetailSelectDataTransfer Model);
        Task<Response<UserDetail>> AnySelectAsync(UserDetailAnyDataTransfer Model);
    }
}