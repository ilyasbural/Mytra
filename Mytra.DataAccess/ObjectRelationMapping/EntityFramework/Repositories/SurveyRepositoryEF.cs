namespace Mytra.DataAccess
{
    public class SurveyRepositoryEF : Core.BaseRepository<Core.Survey>, Core.ISurvey
    {
        public SurveyRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}