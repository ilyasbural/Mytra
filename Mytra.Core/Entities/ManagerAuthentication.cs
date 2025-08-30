namespace Mytra.Core
{
    public class ManagerAuthentication : Base<ManagerAuthentication>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public ManagerAuthentication()
		{
			
		}
	}
}