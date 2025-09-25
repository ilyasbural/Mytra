namespace Mytra.Core
{
    public interface ICandidateReferanceService
    {
		Task<Utilize.DataService<CandidateReferance>> InsertAsync(Utilize.CandidateReferanceInsert Model);
		Task<Utilize.DataService<CandidateReferance>> UpdateAsync(Utilize.CandidateReferanceUpdate Model);
		Task<Utilize.DataService<CandidateReferance>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateReferance>> SelectAsync(Utilize.CandidateReferanceSelect Model);
		Task<Utilize.DataService<CandidateReferance>> SelectSingleAsync(Utilize.CandidateReferanceSelectSingle Model);
	}
}