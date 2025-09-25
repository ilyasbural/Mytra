namespace Mytra.Utilize
{
	public class CandidateAuthenticationResponse : Response<CandidateAuthenticationResponse>
	{
		public String RefreshToken { get; set; } = String.Empty;
		public DateTime RefreshTokenExpireTime { get; set; }
		public CandidateAuthenticationResponse() { }
	}
}