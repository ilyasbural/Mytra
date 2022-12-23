namespace Mytra.Core
{
    public interface ISurveyService
    {
        Task<Response<Survey>> InsertAsync(SurveyInsertDataTransfer Model);
        Task<Response<Survey>> UpdateAsync(SurveyUpdateDataTransfer Model);
        Task<Response<Survey>> DeleteAsync(SurveyDeleteDataTransfer Model);
        Task<Response<Survey>> SelectAsync(SurveySelectDataTransfer Model);
        Task<Response<Survey>> AnySelectAsync(SurveyAnyDataTransfer Model);
    }
}