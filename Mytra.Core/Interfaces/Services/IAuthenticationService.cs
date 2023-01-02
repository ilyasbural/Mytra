namespace Mytra.Core
{
    public interface IAuthenticationService
    {
        Task<AccessToken> CreateAccessToken(string email, string password);
    }
}