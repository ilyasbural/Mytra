namespace Mytra.Core
{
    public interface ICandidateService
    {
		Task<Utilize.DataService<Candidate>> InsertAsync(Utilize.CandidateInsert Model);
		Task<Utilize.DataService<Candidate>> UpdateAsync(Utilize.CandidateUpdate Model);
		Task<Utilize.DataService<Candidate>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<Candidate>> SelectAsync(Utilize.CandidateSelect Model);
		Task<Utilize.DataService<Candidate>> SelectSingleAsync(Utilize.CandidateSelectSingle Model);
	}
}