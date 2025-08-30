namespace Mytra.Core
{
    public class CandidateEducation : Base<CandidateEducation>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public CandidateEducation()
		{
			
		}
	}
}