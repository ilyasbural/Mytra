namespace Mytra.Core
{
    public interface ICandidateExperienceService
    {
		Task<Utilize.DataService<CandidateExperience>> InsertAsync(Utilize.CandidateExperienceInsert Model);
		Task<Utilize.DataService<CandidateExperience>> UpdateAsync(Utilize.CandidateExperienceUpdate Model);
		Task<Utilize.DataService<CandidateExperience>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateExperience>> SelectAsync(Utilize.CandidateExperienceSelect Model);
		Task<Utilize.DataService<CandidateExperience>> SelectSingleAsync(Utilize.CandidateExperienceSelectSingle Model);
	}
}