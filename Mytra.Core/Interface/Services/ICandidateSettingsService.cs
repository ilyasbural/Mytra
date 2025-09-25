namespace Mytra.Core
{
    public interface ICandidateSettingsService
    {
		Task<Utilize.DataService<CandidateSettings>> InsertAsync(Utilize.CandidateSettingsInsert Model);
		Task<Utilize.DataService<CandidateSettings>> UpdateAsync(Utilize.CandidateSettingsUpdate Model);
		Task<Utilize.DataService<CandidateSettings>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateSettings>> SelectAsync(Utilize.CandidateSettingsSelect Model);
		Task<Utilize.DataService<CandidateSettings>> SelectSingleAsync(Utilize.CandidateSettingsSelectSingle Model);
	}
}