namespace Mytra.Core
{
    public interface ICandidateSettingsService
    {
		Task<Common.DataService<CandidateSettings>> InsertAsync(Common.CandidateSettingsInsert Model);
		Task<Common.DataService<CandidateSettings>> UpdateAsync(Common.CandidateSettingsUpdate Model);
		Task<Common.DataService<CandidateSettings>> DeleteAsync(Common.CandidateSettingsDelete Model);
		Task<Common.DataService<CandidateSettings>> SelectAsync(Common.CandidateSettingsSelect Model);
		Task<Common.DataService<CandidateSettings>> SelectSingleAsync(Common.CandidateSettingsSelectSingle Model);
	}
}