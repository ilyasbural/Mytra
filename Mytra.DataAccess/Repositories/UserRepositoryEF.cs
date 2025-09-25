namespace Mytra.DataAccess
{
	public class UserRepositoryEF : RepositoryBase<Core.User>, Core.IUser
	{
		public UserRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}