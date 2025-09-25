namespace Mytra.Core
{
	public class CandidateCertificate : Base<CandidateCertificate>, IEntity
	{
		public String Name { get; set; } = String.Empty;

		public CandidateCertificate()
		{

		}
	}
}