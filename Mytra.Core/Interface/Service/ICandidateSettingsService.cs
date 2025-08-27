namespace Mytra.Core
{
    public interface ICandidateSettingsService
    {
		Task<Common.ServiceResponse<Common.CandidateSettingsResponse>> InsertAsync(Common.CandidateSettingsInsert Model);
		Task<Common.ServiceResponse<Common.CandidateSettingsResponse>> UpdateAsync(Common.CandidateSettingsUpdate Model);
		Task<Common.ServiceResponse<Common.CandidateSettingsResponse>> DeleteAsync(Common.CandidateSettingsDelete Model);
		Task<Common.ServiceResponse<Common.CandidateSettingsResponse>> SelectAsync(Common.CandidateSettingsSelect Model);
		Task<Common.ServiceResponse<Common.CandidateSettingsResponse>> SelectSingleAsync(Common.CandidateSettingsSelectSingle Model);
	}
}