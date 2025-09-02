namespace Mytra.Core
{
	public class CandidateAuthentication : Base<CandidateAuthentication>, IEntity
	{
		public Candidate Candidate { get; set; } = new Candidate();
		public String RefreshToken { get; set; } = String.Empty;
		public DateTime RefreshTokenExpireTime { get; set; }

		public CandidateAuthentication()
		{

		}
	}
}