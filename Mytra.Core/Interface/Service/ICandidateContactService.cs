namespace Mytra.Core
{
    public interface ICandidateContactService
    {
		Task<Common.DataService<CandidateContact>> InsertAsync(Common.CandidateContactInsert Model);
		//Task<Common.ServiceResponse<Common.CandidateContactResponse>> UpdateAsync(Common.CandidateContactUpdate Model);
		//Task<Common.ServiceResponse<Common.CandidateContactResponse>> DeleteAsync(Common.CandidateContactDelete Model);
		//Task<Common.ServiceResponse<Common.CandidateContactResponse>> SelectAsync(Common.CandidateContactSelect Model);
		//Task<Common.ServiceResponse<Common.CandidateContactResponse>> SelectSingleAsync(Common.CandidateContactSelectSingle Model);
	}
}