namespace Mytra.Common
{
	public class CandidateResponse : Response<CandidateResponse>
	{
		public String Email { get; set; } = String.Empty;
		public String Password { get; set; } = String.Empty;
		public DateTime RegisterDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsActive { get; set; }
		public CandidateResponse() { }
	}
}