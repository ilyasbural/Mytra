namespace Mytra.Core
{
    public class CandidateDetail : Base<CandidateDetail>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public CandidateDetail()
		{
			
		}
	}
}