namespace Mytra.Core
{
    public interface IAuthenticationService
    {
        AccessToken CreateAccessToken(string email, string password);
    }
}