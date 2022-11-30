namespace Mytra.Core
{
    public interface IUserContactService
    {
        Task<UserContactResponse> AddAsync(UserContactInsertDataTransfer Model);
    }
}