namespace Mytra.DataAccess
{
	public class CollegeRepositoryEF : RepositoryBase<Core.College>, Core.ICollege
	{
		public CollegeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}