namespace Mytra.Core
{
    public interface ISurveyDetailService
    {
        Task<Response<SurveyDetail>> InsertAsync(SurveyDetailInsertDataTransfer Model);
        Task<Response<SurveyDetail>> UpdateAsync(SurveyDetailUpdateDataTransfer Model);
        Task<Response<SurveyDetail>> DeleteAsync(SurveyDetailDeleteDataTransfer Model);
        Task<Response<SurveyDetail>> SelectAsync(SurveyDetailSelectDataTransfer Model);
        Task<Response<SurveyDetail>> AnySelectAsync(SurveyDetailAnyDataTransfer Model);
    }
}