namespace Mytra.Core
{
    public interface ISurveyService
    {
        Task<SurveyResponse> AddAsync(SurveyInsertDataTransfer Model);
    }
}