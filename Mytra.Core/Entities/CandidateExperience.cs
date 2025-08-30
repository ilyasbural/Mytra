namespace Mytra.Core
{
    public class CandidateExperience : Base<CandidateExperience>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public CandidateExperience()
		{
			
		}
	}
}