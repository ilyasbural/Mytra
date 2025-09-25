namespace Mytra.Core
{
	public class CandidateContact : Base<CandidateContact>, IEntity
	{
		public String Name { get; set; } = String.Empty;

		public CandidateContact()
		{

		}
	}
}