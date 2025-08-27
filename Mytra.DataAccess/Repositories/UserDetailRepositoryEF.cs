namespace Mytra.DataAccess
{
	public class UserDetailRepositoryEF : RepositoryBase<Core.UserDetail>, Core.IUserDetail
	{
		public UserDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}