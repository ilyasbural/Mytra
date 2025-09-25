namespace Mytra.Core
{
    public class Language : Base<Language>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public Language()
		{
			
		}
	}
}