namespace Mytra.Core
{
    public interface ICandidateDetailService
    {
		Task<Common.ServiceResponse<Common.CandidateDetailResponse>> InsertAsync(Common.CandidateDetailInsert Model);
		Task<Common.ServiceResponse<Common.CandidateDetailResponse>> UpdateAsync(Common.CandidateDetailUpdate Model);
		Task<Common.ServiceResponse<Common.CandidateDetailResponse>> DeleteAsync(Common.CandidateDetailDelete Model);
		Task<Common.ServiceResponse<Common.CandidateDetailResponse>> SelectAsync(Common.CandidateDetailSelect Model);
		Task<Common.ServiceResponse<Common.CandidateDetailResponse>> SelectSingleAsync(Common.CandidateDetailSelectSingle Model);
	}
}