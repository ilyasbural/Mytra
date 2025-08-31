namespace Mytra.Core
{
    public interface ICandidateService
    {
		Task<Common.DataService<Candidate>> InsertAsync(Common.CandidateInsert Model);
		Task<Common.DataService<Candidate>> UpdateAsync(Common.CandidateUpdate Model);
		Task<Common.DataService<Candidate>> DeleteAsync(Common.CandidateDelete Model);
		Task<Common.DataService<Candidate>> SelectAsync(Common.CandidateSelect Model);
		Task<Common.DataService<Candidate>> SelectSingleAsync(Common.CandidateSelectSingle Model);
	}
}