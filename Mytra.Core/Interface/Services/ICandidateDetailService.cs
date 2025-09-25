namespace Mytra.Core
{
    public interface ICandidateDetailService
    {
		Task<Utilize.DataService<CandidateDetail>> InsertAsync(Utilize.CandidateDetailInsert Model);
		Task<Utilize.DataService<CandidateDetail>> UpdateAsync(Utilize.CandidateDetailUpdate Model);
		Task<Utilize.DataService<CandidateDetail>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateDetail>> SelectAsync(Utilize.CandidateDetailSelect Model);
		Task<Utilize.DataService<CandidateDetail>> SelectSingleAsync(Utilize.CandidateDetailSelectSingle Model);
	}
}