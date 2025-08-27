namespace Mytra.DataAccess
{
	public class CandidatePhotoRepositoryEF : RepositoryBase<Core.CandidatePhoto>, Core.ICandidatePhoto
	{
		public CandidatePhotoRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}