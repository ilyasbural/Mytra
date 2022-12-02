namespace Mytra.Core
{
    public interface IUserEmailService
    {
        Task<UserEmailResponse> AddAsync(UserEmailInsertDataTransfer Model);
        Task<UserEmailResponse> UpdateAsync(UserEmailUpdateDataTransfer Model);
    }
}