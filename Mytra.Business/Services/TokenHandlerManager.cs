namespace Mytra.Business
{
    using Core;
    using System.Security.Claims;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;

    public class TokenHandlerManager : ITokenHandlerService
    {
        readonly TokenOptions Options;
        public TokenHandlerManager(IOptions<TokenOptions> options)
        {
            Options = options.Value;
        }

        public AccessToken CreateAccessToken(User user, UserDetail userDetail)
        {
            DateTime accessTokenExpiration = DateTime.Now.AddMinutes(Options.AccessTokenExpiration);
            SecurityKey SecurityKey = SignHandler.GetSecurityKey(Options.SecurityKey);
            SigningCredentials signingCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256Signature);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: Options.Issuer, audience: Options.Audience, expires: accessTokenExpiration, notBefore: DateTime.Now, claims: GetClaim(user, userDetail), signingCredentials: signingCredentials);

            var handler = new JwtSecurityTokenHandler();
            var token = handler.WriteToken(jwtSecurityToken);
            AccessToken accessToken = new AccessToken();
            accessToken.Token = token;
            accessToken.Expiration = accessToken.Expiration;
            return accessToken;
        }

        private IEnumerable<Claim> GetClaim(User user, UserDetail userDetail)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(ClaimTypes.Name, $" {userDetail.Name} {userDetail.Lastname} "),
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