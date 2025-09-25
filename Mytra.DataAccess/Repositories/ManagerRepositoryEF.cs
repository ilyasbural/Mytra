namespace Mytra.DataAccess
{
	public class ManagerRepositoryEF : RepositoryBase<Core.Manager>, Core.IManager
	{
		public ManagerRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}