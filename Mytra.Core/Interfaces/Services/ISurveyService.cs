namespace Mytra.Core
{
    public interface ISurveyService
    {
        Task<SurveyResponse> AddAsync(SurveyInsertDataTransfer Model);
        Task<SurveyResponse> UpdateAsync(SurveyUpdateDataTransfer Model);
    }
}