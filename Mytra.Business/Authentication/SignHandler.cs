namespace Mytra.Business
{
    public class SignHandler
    {
        public static Microsoft.IdentityModel.Tokens.SecurityKey GetSecurityKey(string securityKey)
        {
            return new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(securityKey));
        }
    }
}