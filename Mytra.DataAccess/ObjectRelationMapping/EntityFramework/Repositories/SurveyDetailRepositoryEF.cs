namespace Mytra.DataAccess
{
    public class SurveyDetailRepositoryEF : BaseRepository<Core.SurveyDetail>, Core.ISurveyDetailRepository
    {
        public SurveyDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}