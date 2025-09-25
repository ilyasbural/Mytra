namespace Mytra.DataAccess
{
	public class CandidateEducationRepositoryEF : RepositoryBase<Core.CandidateEducation>, Core.ICandidateEducation
	{
		public CandidateEducationRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}