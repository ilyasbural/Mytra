namespace Mytra.Core
{
    public class CandidateReferance : Base<CandidateReferance>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public CandidateReferance()
		{
			
		}
	}
}