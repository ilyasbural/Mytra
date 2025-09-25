namespace Mytra.Core
{
    public class College : Base<College>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public College()
		{
			
		}
	}
}