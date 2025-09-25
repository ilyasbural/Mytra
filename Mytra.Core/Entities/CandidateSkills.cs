namespace Mytra.Core
{
    public class CandidateSkills : Base<CandidateSkills>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public CandidateSkills()
		{
			
		}
	}
}