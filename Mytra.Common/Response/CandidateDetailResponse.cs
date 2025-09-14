namespace Mytra.Common
{
	public class CandidateDetailResponse : Response<CandidateDetailResponse>
	{
		public String Name { get; set; } = String.Empty;
		public CandidateDetailResponse() { }
	}
}