namespace Mytra.Common
{
	public class CandidateContactResponse : Response<CandidateContactResponse>
	{
		public String Name { get; set; } = String.Empty;
		public CandidateContactResponse() { }
	}
}