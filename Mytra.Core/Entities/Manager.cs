namespace Mytra.Core
{
    public class Manager : Base<Manager>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public Manager()
		{
			
		}
	}
}