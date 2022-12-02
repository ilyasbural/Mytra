namespace Mytra.Core
{
    public interface IUserContactService
    {
        Task<UserContactResponse> AddAsync(UserContactInsertDataTransfer Model);
        Task<UserContactResponse> UpdateAsync(UserContactUpdateDataTransfer Model);
        Task<UserContactResponse> DeleteAsync(UserContactDeleteDataTransfer Model);
        Task<UserContactResponse> SelectAsync(UserContactSelectDataTransfer Model);
        Task<UserContactResponse> AnyAsync(UserContactAnyDataTransfer Model);
    }
}