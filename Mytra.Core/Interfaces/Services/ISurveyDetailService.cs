namespace Mytra.Core
{
    public interface ISurveyDetailService
    {
        Task<SurveyDetailResponse> AddAsync(SurveyDetailInsertDataTransfer Model);
        Task<SurveyDetailResponse> UpdateAsync(SurveyDetailUpdateDataTransfer Model);
    }
}