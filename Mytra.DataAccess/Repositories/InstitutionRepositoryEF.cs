namespace Mytra.DataAccess
{
	public class InstitutionRepositoryEF : RepositoryBase<Core.Institution>, Core.IInstitution
	{
		public InstitutionRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}