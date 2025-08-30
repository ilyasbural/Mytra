namespace Mytra.Core
{
    public class UserAuthentication : Base<UserAuthentication>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public UserAuthentication()
		{
			
		}
	}
}