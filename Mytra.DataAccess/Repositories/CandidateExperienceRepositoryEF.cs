namespace Mytra.DataAccess
{
	public class CandidateExperienceRepositoryEF : RepositoryBase<Core.CandidateExperience>, Core.ICandidateExperience
	{
		public CandidateExperienceRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}