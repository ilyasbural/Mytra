namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class AuthenticationManager : IAuthenticationService
    {
        readonly ITokenHandlerService tokenHandler;
        public AuthenticationManager(ITokenHandlerService tokenHandler)
        {
            this.tokenHandler = tokenHandler;
        }

        public async Task<AccessToken> CreateAccessToken(string email, string password)
        {
            AccessToken accessToken = tokenHandler.CreateAccessToken(new User
            {
                Email = email, 
                Password = password
            }, new UserDetail {     });
            return accessToken;
        }
    }
}