namespace Mytra.Business
{
    using Core;
    using System.Security.Claims;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;

    public class TokenHandlerManager : ITokenHandlerService
    {
        private readonly TokenOptions tokenOptions;

        public TokenHandlerManager(IOptions<TokenOptions> tokenOptions)
        {
            this.tokenOptions = tokenOptions.Value;
        }

        public AccessToken CreateAccessToken(User user)
        {
            var accessTokenExpiration = DateTime.Now.AddMinutes(tokenOptions.AccessTokenExpiration);
            var securityKey = SignHandler.GetSecurityKey(tokenOptions.SecurityKey);
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: tokenOptions.Issuer, audience: tokenOptions.Audience, expires: accessTokenExpiration, notBefore: DateTime.Now, claims: GetClaim(user), signingCredentials: signingCredentials);

            var handler = new JwtSecurityTokenHandler();
            var token = handler.WriteToken(jwtSecurityToken);
            AccessToken accessToken = new AccessToken();
            accessToken.Token = token;
            accessToken.Expiration = accessToken.Expiration;
            return accessToken;
        }

        private IEnumerable<Claim> GetClaim(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                //new Claim(JwtRegisteredClaimNames.Email, user.Email),
                //new Claim(ClaimTypes.Name, $" {user.Name} {user.Surname} "),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            return claims;
        }

        public void RevokeRefreshToken(User user)
        {
            throw new NotImplementedException();
        }
    }
}