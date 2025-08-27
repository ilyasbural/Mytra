namespace Mytra.DataAccess
{
	public class SkillsRepositoryEF : RepositoryBase<Core.Skills>, Core.ISkills
	{
		public SkillsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}