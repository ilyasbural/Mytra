namespace Mytra.DataAccess
{
	public class CandidateSkillsRepositoryEF : RepositoryBase<Core.CandidateSkills>, Core.ICandidateSkills
	{
		public CandidateSkillsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}