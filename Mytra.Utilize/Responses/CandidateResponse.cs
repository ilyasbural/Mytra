namespace Mytra.Utilize
{
	public class CandidateResponse : Response<CandidateResponse>
	{
		public String Email { get; set; } = String.Empty;
		public String Password { get; set; } = String.Empty;
		public CandidateResponse() { }
	}
}