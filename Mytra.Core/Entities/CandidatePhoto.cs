namespace Mytra.Core
{
    public class CandidatePhoto : Base<CandidatePhoto>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public CandidatePhoto()
		{
			
		}
	}
}