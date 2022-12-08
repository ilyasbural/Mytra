namespace Mytra.Core
{
    public interface IUserEmailService
    {
        Task<UserEmailResponse> InsertAsync(UserEmailInsertDataTransfer Model);
        Task<UserEmailResponse> UpdateAsync(UserEmailUpdateDataTransfer Model);
        Task<UserEmailResponse> DeleteAsync(UserEmailDeleteDataTransfer Model);
        Task<UserEmailResponse> SelectAsync(UserEmailSelectDataTransfer Model);
        Task<UserEmailResponse> AnyAsync(UserEmailAnyDataTransfer Model);
    }
}