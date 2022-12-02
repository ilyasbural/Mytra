namespace Mytra.Business
{
    public class SurveyDetailMapper : AutoMapper.Profile
    {
        public SurveyDetailMapper()
        {
            CreateMap<Core.SurveyDetailInsertDataTransfer, Core.SurveyDetail>();
            CreateMap<Core.SurveyDetailUpdateDataTransfer, Core.SurveyDetail>();
            CreateMap<Core.SurveyDetailDeleteDataTransfer, Core.SurveyDetail>();
            CreateMap<Core.SurveyDetailSelectDataTransfer, Core.SurveyDetail>();
            CreateMap<Core.SurveyDetailUpdateDataTransfer, Core.SurveyDetail>();
        }
    }
}