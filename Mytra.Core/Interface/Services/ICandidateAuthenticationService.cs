namespace Mytra.Core
{
    public interface ICandidateAuthenticationService
    {
		Task<Utilize.DataService<CandidateAuthentication>> InsertAsync(Utilize.CandidateAuthenticationInsert Model);
		Task<Utilize.DataService<CandidateAuthentication>> UpdateAsync(Utilize.CandidateAuthenticationUpdate Model);
		Task<Utilize.DataService<CandidateAuthentication>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateAuthentication>> SelectAsync(Utilize.CandidateAuthenticationSelect Model);
		Task<Utilize.DataService<CandidateAuthentication>> SelectSingleAsync(Utilize.CandidateAuthenticationSelectSingle Model);
	}
}