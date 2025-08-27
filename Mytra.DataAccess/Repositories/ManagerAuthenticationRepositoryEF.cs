namespace Mytra.DataAccess
{
	public class ManagerAuthenticationRepositoryEF : RepositoryBase<Core.ManagerAuthentication>, Core.IManagerAuthentication
	{
		public ManagerAuthenticationRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}