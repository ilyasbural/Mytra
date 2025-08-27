namespace Mytra.DataAccess
{
	public class ManagerDetailRepositoryEF : RepositoryBase<Core.ManagerDetail>, Core.IManagerDetail
	{
		public ManagerDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}