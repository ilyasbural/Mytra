namespace Mytra.Utilize
{
	public class CandidateAuthenticationInsert
	{
		public Guid CandidateId { get; set; }
		public String RefreshToken { get; set; } = null!;
		public DateTime RefreshTokenExpireTime { get; set; }
	}
}