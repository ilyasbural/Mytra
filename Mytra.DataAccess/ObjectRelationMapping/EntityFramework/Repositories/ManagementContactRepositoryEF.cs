namespace Mytra.DataAccess
{
    public class ManagementContactRepositoryEF : RepositoryBase<Core.ManagementContact>, Core.IManagementContactRepository
    {
        public ManagementContactRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}