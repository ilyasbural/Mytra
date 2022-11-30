namespace Mytra.DataAccess
{
    public class SurveyRepositoryEF : BaseRepository<Core.Survey>, Core.ISurveyRepository
    {
        public SurveyRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}