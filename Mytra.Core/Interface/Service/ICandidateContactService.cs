namespace Mytra.Core
{
    public interface ICandidateContactService
    {
		Task<Common.DataService<CandidateContact>> InsertAsync(Common.CandidateContactInsert Model);
		Task<Common.DataService<CandidateContact>> UpdateAsync(Common.CandidateContactUpdate Model);
		Task<Common.DataService<CandidateContact>> DeleteAsync(Common.CandidateContactDelete Model);
		Task<Common.DataService<CandidateContact>> SelectAsync(Common.CandidateContactSelect Model);
		Task<Common.DataService<CandidateContact>> SelectSingleAsync(Common.CandidateContactSelectSingle Model);
	}
}