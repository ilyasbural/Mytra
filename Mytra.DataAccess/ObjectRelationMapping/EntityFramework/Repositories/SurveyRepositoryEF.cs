namespace Mytra.DataAccess
{
    public class SurveyRepositoryEF : RepositoryBase<Core.Survey>, Core.ISurveyRepository
    {
        public SurveyRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}