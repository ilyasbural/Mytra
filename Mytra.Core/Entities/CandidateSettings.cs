namespace Mytra.Core
{
    public class CandidateSettings : Base<CandidateSettings>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public CandidateSettings()
		{
			
		}
	}
}