namespace Mytra.Core
{
    public interface ICandidateExperienceService
    {
		Task<Common.DataService<CandidateExperience>> InsertAsync(Common.CandidateExperienceInsert Model);
		//Task<Common.ServiceResponse<Common.CandidateExperienceResponse>> UpdateAsync(Common.CandidateExperienceUpdate Model);
		//Task<Common.ServiceResponse<Common.CandidateExperienceResponse>> DeleteAsync(Common.CandidateExperienceDelete Model);
		//Task<Common.ServiceResponse<Common.CandidateExperienceResponse>> SelectAsync(Common.CandidateExperienceSelect Model);
		//Task<Common.ServiceResponse<Common.CandidateExperienceResponse>> SelectSingleAsync(Common.CandidateExperienceSelectSingle Model);
	}
}