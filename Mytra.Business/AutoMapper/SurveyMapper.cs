namespace Mytra.Business
{
    public class SurveyMapper : AutoMapper.Profile
    {
        public SurveyMapper()
        {
            CreateMap<Core.SurveyInsertDataTransfer, Core.Survey>();
            CreateMap<Core.SurveyUpdateDataTransfer, Core.Survey>();
            CreateMap<Core.SurveyDeleteDataTransfer, Core.Survey>();
            CreateMap<Core.SurveySelectDataTransfer, Core.Survey>();
            CreateMap<Core.SurveyUpdateDataTransfer, Core.Survey>();
        }
    }
}