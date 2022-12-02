namespace Mytra.Business
{
    public class SurveyMapper : AutoMapper.Profile
    {
        public SurveyMapper()
        {
            CreateMap<Core.SurveyInsertDataTransfer, Core.Survey>();
            CreateMap<Core.SurveyUpdateDataTransfer, Core.Survey>();
        }
    }
}