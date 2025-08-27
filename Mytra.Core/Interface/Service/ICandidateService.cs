namespace Mytra.Core
{
    public interface ICandidateService
    {
		Task<Common.ServiceResponse<Common.CandidateResponse>> InsertAsync(Common.CandidateInsert Model);
		Task<Common.ServiceResponse<Common.CandidateResponse>> UpdateAsync(Common.CandidateUpdate Model);
		Task<Common.ServiceResponse<Common.CandidateResponse>> DeleteAsync(Common.CandidateDelete Model);
		Task<Common.ServiceResponse<Common.CandidateResponse>> SelectAsync(Common.CandidateSelect Model);
		Task<Common.ServiceResponse<Common.CandidateResponse>> SelectSingleAsync(Common.CandidateSelectSingle Model);
	}
}