namespace Mytra.Core
{
    public interface ICandidateEducationService
    {
		Task<Common.DataService<CandidateEducation>> InsertAsync(Common.CandidateEducationInsert Model);
		Task<Common.DataService<CandidateEducation>> UpdateAsync(Common.CandidateEducationUpdate Model);
		Task<Common.DataService<CandidateEducation>> DeleteAsync(Common.CandidateEducationDelete Model);
		Task<Common.DataService<CandidateEducation>> SelectAsync(Common.CandidateEducationSelect Model);
		Task<Common.DataService<CandidateEducation>> SelectSingleAsync(Common.CandidateEducationSelectSingle Model);
	}
}