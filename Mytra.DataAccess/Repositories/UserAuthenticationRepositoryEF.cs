namespace Mytra.DataAccess
{
	public class UserAuthenticationRepositoryEF : RepositoryBase<Core.UserAuthentication>, Core.IUserAuthentication
	{
		public UserAuthenticationRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}