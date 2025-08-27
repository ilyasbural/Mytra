namespace Mytra.DataAccess
{
	public class CandidateCertificateRepositoryEF : RepositoryBase<Core.CandidateCertificate>, Core.ICandidateCertificate
	{
		public CandidateCertificateRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}