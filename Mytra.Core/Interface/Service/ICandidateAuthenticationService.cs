namespace Mytra.Core
{
    public interface ICandidateAuthenticationService
    {
		Task<Common.DataService<CandidateAuthentication>> InsertAsync(Common.CandidateAuthenticationInsert Model);
		Task<Common.DataService<CandidateAuthentication>> UpdateAsync(Common.CandidateAuthenticationUpdate Model);
		Task<Common.DataService<CandidateAuthentication>> DeleteAsync(Guid Id);
		Task<Common.DataService<CandidateAuthentication>> SelectAsync(Common.CandidateAuthenticationSelect Model);
		Task<Common.DataService<CandidateAuthentication>> SelectSingleAsync(Common.CandidateAuthenticationSelectSingle Model);
	}
}