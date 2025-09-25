namespace Mytra.Utilize
{
	public class CandidateAuthenticationUpdate
	{
		public Guid Id { get; set; }
		public String RefreshToken { get; set; } = String.Empty;
		public DateTime RefreshTokenExpireTime { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsActive { get; set; }
		public CandidateAuthenticationUpdate() { }
	}
}