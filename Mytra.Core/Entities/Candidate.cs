namespace Mytra.Core
{
	public class Candidate : Base<Candidate>, IEntity
	{
		public String Email { get; set; } = String.Empty;
		public String Password { get; set; } = String.Empty;

		public Candidate()
		{

		}
	}
}