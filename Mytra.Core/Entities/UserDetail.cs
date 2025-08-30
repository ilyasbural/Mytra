namespace Mytra.Core
{
    public class UserDetail : Base<UserDetail>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public UserDetail()
		{
			
		}
	}
}