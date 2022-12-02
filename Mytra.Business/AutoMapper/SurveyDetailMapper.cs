namespace Mytra.Business
{
    public class SurveyDetailMapper : AutoMapper.Profile
    {
        public SurveyDetailMapper()
        {
            CreateMap<Core.SurveyDetailInsertDataTransfer, Core.SurveyDetail>();
            CreateMap<Core.SurveyDetailUpdateDataTransfer, Core.SurveyDetail>();
        }
    }
}