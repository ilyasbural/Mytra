namespace Mytra.Core
{
    public class User : Base<User>, IEntity
    {
		public String Email { get; set; } = String.Empty;
		public String Password { get; set; } = String.Empty;

		public User()
		{
			
		}
	}
}