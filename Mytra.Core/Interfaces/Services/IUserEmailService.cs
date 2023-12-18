namespace Mytra.Core
{
    public interface IUserEmailService
    {
        Task<Response<UserEmail>> InsertAsync(UserEmailInsertDataTransfer Model);
        Task<Response<UserEmail>> UpdateAsync(UserEmailUpdateDataTransfer Model);
        Task<Response<UserEmail>> DeleteAsync(UserEmailDeleteDataTransfer Model);
        Task<Response<UserEmail>> SelectAsync(UserEmailSelectDataTransfer Model);
        Task<Response<UserEmail>> AnySelectAsync(UserEmailAnyDataTransfer Model);
    }
}