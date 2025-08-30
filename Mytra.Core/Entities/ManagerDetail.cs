namespace Mytra.Core
{
    public class ManagerDetail : Base<ManagerDetail>, IEntity
    {
		public String Name { get; set; } = String.Empty;

		public ManagerDetail()
		{
			
		}
	}
}