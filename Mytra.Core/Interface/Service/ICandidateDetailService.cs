namespace Mytra.Core
{
    public interface ICandidateDetailService
    {
		Task<Common.DataService<CandidateDetail>> InsertAsync(Common.CandidateDetailInsert Model);
		Task<Common.DataService<CandidateDetail>> UpdateAsync(Common.CandidateDetailUpdate Model);
		Task<Common.DataService<CandidateDetail>> DeleteAsync(Guid Id);
		Task<Common.DataService<CandidateDetail>> SelectAsync(Common.CandidateDetailSelect Model);
		Task<Common.DataService<CandidateDetail>> SelectSingleAsync(Common.CandidateDetailSelectSingle Model);
	}
}