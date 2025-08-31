namespace Mytra.Core
{
    public interface ICandidateAuthenticationService
    {
		Task<Common.DataService<CandidateAuthentication>> InsertAsync(Common.CandidateAuthenticationInsert Model);
		//Task<Common.ServiceResponse<Common.CandidateAuthenticationResponse>> UpdateAsync(Common.CandidateAuthenticationUpdate Model);
		//Task<Common.ServiceResponse<Common.CandidateAuthenticationResponse>> DeleteAsync(Common.CandidateAuthenticationDelete Model);
		//Task<Common.ServiceResponse<Common.CandidateAuthenticationResponse>> SelectAsync(Common.CandidateAuthenticationSelect Model);
		//Task<Common.ServiceResponse<Common.CandidateAuthenticationResponse>> SelectSingleAsync(Common.CandidateAuthenticationSelectSingle Model);
	}
}