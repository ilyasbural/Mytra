namespace Mytra.DataAccess
{
    public class ManagementContactRepositoryEF : BaseRepository<Core.ManagementContact>, Core.IManagementContactRepository
    {
        public ManagementContactRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}