namespace Mytra.Business
{
    using Core;

    public class AuthenticationManager : IAuthenticationService
    {
        readonly ITokenHandlerService tokenHandler;
        public AuthenticationManager(ITokenHandlerService tokenHandler)
        {
            this.tokenHandler = tokenHandler;
        }

        public AccessToken CreateAccessToken(string email, string password)
        {
            AccessToken accessToken = tokenHandler.CreateAccessToken(new User
            {
                //Id = 1,
                //Email = "ilyas@GMAİL.COM",
                //Name = "ilyaS",
                //Surname = "SS"
            });
            return accessToken;
        }
    }
}