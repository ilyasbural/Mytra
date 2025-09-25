namespace Mytra.Core
{
    public interface ICandidateEducationService
    {
		Task<Utilize.DataService<CandidateEducation>> InsertAsync(Utilize.CandidateEducationInsert Model);
		Task<Utilize.DataService<CandidateEducation>> UpdateAsync(Utilize.CandidateEducationUpdate Model);
		Task<Utilize.DataService<CandidateEducation>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateEducation>> SelectAsync(Utilize.CandidateEducationSelect Model);
		Task<Utilize.DataService<CandidateEducation>> SelectSingleAsync(Utilize.CandidateEducationSelectSingle Model);
	}
}