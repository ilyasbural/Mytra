namespace Mytra.Utilize
{
	public class CandidateSettingsResponse : Response<CandidateSettingsResponse>
	{
		public String Name { get; set; } = String.Empty;
		public CandidateSettingsResponse() { }
	}
}