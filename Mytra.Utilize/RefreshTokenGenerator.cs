namespace Mytra.Utilize
{
	public class RefreshTokenGenerator
	{
		public string GenerateRefreshToken()
		{
			Byte[] randomNumber = new byte[32];
			using (var Rng = System.Security.Cryptography.RandomNumberGenerator.Create())
			{
				Rng.GetBytes(randomNumber);
				return Convert.ToBase64String(randomNumber);
			}
		}
	}
}