namespace Mytra.Presentation
{
	public class RefreshTokenGenerator
	{
		public string GenerateRefreshToken()
		{
			var randomNumber = new byte[32];
			using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
			{
				rng.GetBytes(randomNumber);
				return Convert.ToBase64String(randomNumber);
			}
		}
	}
}