namespace Mytra.Common
{
	public class CandidateAuthenticationResponse : Response<CandidateAuthenticationResponse>
	{
		public String RefreshToken { get; set; } = String.Empty;
		public DateTime RefreshTokenExpireTime { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsActive { get; set; }
		public CandidateAuthenticationResponse() { }
	}
}