namespace Mytra.Core
{
    public interface IUserContactService
    {
        Task<Response<UserContact>> InsertAsync(UserContactInsertDataTransfer Model);
        Task<Response<UserContact>> UpdateAsync(UserContactUpdateDataTransfer Model);
        Task<Response<UserContact>> DeleteAsync(UserContactDeleteDataTransfer Model);
        Task<Response<UserContact>> SelectAsync(UserContactSelectDataTransfer Model);
        Task<Response<UserContact>> AnySelectAsync(UserContactAnyDataTransfer Model);
    }
}