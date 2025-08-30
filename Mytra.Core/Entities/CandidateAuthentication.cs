namespace Mytra.Core
{
	public class CandidateAuthentication : Base<CandidateAuthentication>, IEntity
	{
		public String Name { get; set; } = String.Empty;

		public CandidateAuthentication()
		{

		}
	}
}