namespace Mytra.Core
{
    public class UserSettings : Base<UserSettings>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public UserSettings()
		{
			
		}
	}
}