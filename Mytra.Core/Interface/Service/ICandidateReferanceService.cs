namespace Mytra.Core
{
    public interface ICandidateReferanceService
    {
		Task<Common.DataService<CandidateReferance>> InsertAsync(Common.CandidateReferanceInsert Model);
		Task<Common.DataService<CandidateReferance>> UpdateAsync(Common.CandidateReferanceUpdate Model);
		Task<Common.DataService<CandidateReferance>> DeleteAsync(Common.CandidateReferanceDelete Model);
		Task<Common.DataService<CandidateReferance>> SelectAsync(Common.CandidateReferanceSelect Model);
		Task<Common.DataService<CandidateReferance>> SelectSingleAsync(Common.CandidateReferanceSelectSingle Model);
	}
}