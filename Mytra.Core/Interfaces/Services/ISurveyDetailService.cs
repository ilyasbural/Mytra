namespace Mytra.Core
{
    public interface ISurveyDetailService
    {
        Task<SurveyDetailResponse> AddAsync(SurveyDetailInsertDataTransfer Model);
        Task<SurveyDetailResponse> UpdateAsync(SurveyDetailUpdateDataTransfer Model);
        Task<SurveyDetailResponse> DeleteAsync(SurveyDetailDeleteDataTransfer Model);
        Task<SurveyDetailResponse> SelectAsync(SurveyDetailSelectDataTransfer Model);
        Task<SurveyDetailResponse> AnyAsync(SurveyDetailAnyDataTransfer Model);
    }
}