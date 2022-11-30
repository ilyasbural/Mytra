namespace Mytra.Core
{
    public interface ISurveyDetailService
    {
        Task<SurveyDetailResponse> AddAsync(SurveyDetailInsertDataTransfer Model);
    }
}