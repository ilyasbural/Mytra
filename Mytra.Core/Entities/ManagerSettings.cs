namespace Mytra.Core
{
    public class ManagerSettings : Base<ManagerSettings>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public ManagerSettings()
		{
			
		}
	}
}