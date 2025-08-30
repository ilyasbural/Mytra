namespace Mytra.Core
{
	public class Candidate : Base<Candidate>, IEntity
	{
		public String Name { get; set; } = String.Empty;

		public Candidate()
		{

		}
	}
}