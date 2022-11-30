namespace Mytra.Core
{
    public interface IUserEmailService
    {
        Task<UserEmailResponse> AddAsync(UserEmailInsertDataTransfer Model);
    }
}