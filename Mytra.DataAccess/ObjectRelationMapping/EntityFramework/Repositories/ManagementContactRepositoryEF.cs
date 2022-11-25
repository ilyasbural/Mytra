namespace Mytra.DataAccess
{
    public class ManagementContactRepositoryEF : Core.BaseRepository<Core.ManagementContact>, Core.IManagementContact
    {
        public ManagementContactRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}