namespace Mytra.Core
{
    public interface ISurveyService
    {
        Task<SurveyResponse> AddAsync(SurveyInsertDataTransfer Model);
        Task<SurveyResponse> UpdateAsync(SurveyUpdateDataTransfer Model);
        Task<SurveyResponse> DeleteAsync(SurveyDeleteDataTransfer Model);
        Task<SurveyResponse> SelectAsync(SurveySelectDataTransfer Model);
        Task<SurveyResponse> AnyAsync(SurveyAnyDataTransfer Model);
    }
}