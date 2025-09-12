namespace Mytra.Core
{
    public interface ICandidateExperienceService
    {
		Task<Common.DataService<CandidateExperience>> InsertAsync(Common.CandidateExperienceInsert Model);
		Task<Common.DataService<CandidateExperience>> UpdateAsync(Common.CandidateExperienceUpdate Model);
		Task<Common.DataService<CandidateExperience>> DeleteAsync(Guid Id);
		Task<Common.DataService<CandidateExperience>> SelectAsync(Common.CandidateExperienceSelect Model);
		Task<Common.DataService<CandidateExperience>> SelectSingleAsync(Common.CandidateExperienceSelectSingle Model);
	}
}