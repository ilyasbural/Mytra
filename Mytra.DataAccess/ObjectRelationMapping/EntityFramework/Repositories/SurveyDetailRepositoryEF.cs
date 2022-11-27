namespace Mytra.DataAccess
{
    public class SurveyDetailRepositoryEF : Core.BaseRepository<Core.SurveyDetail>, Core.ISurveyDetail
    {
        public SurveyDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}