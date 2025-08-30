namespace Mytra.Core
{
    public class User : Base<User>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public User()
		{
			
		}
	}
}