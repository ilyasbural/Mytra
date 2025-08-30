namespace Mytra.Core
{
    public class CandidateLanguage : Base<CandidateLanguage>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public CandidateLanguage()
		{
			
		}
	}
}