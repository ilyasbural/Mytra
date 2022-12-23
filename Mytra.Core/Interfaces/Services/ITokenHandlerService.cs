namespace Mytra.Core
{
    public interface ITokenHandlerService
    {
        AccessToken CreateAccessToken(User user);
        void RevokeRefreshToken(User user);
    }
}