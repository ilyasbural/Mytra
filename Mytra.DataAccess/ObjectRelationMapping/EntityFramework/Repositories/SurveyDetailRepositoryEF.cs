namespace Mytra.DataAccess
{
    public class SurveyDetailRepositoryEF : RepositoryBase<Core.SurveyDetail>, Core.ISurveyDetailRepository
    {
        public SurveyDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}