namespace Mytra.Core
{
    public class Institution : Base<Institution>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public Institution()
		{
			
		}
	}
}