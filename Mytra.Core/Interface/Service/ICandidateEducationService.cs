namespace Mytra.Core
{
    public interface ICandidateEducationService
    {
		Task<Common.ServiceResponse<Common.CandidateEducationResponse>> InsertAsync(Common.CandidateEducationInsert Model);
		Task<Common.ServiceResponse<Common.CandidateEducationResponse>> UpdateAsync(Common.CandidateEducationUpdate Model);
		Task<Common.ServiceResponse<Common.CandidateEducationResponse>> DeleteAsync(Common.CandidateEducationDelete Model);
		Task<Common.ServiceResponse<Common.CandidateEducationResponse>> SelectAsync(Common.CandidateEducationSelect Model);
		Task<Common.ServiceResponse<Common.CandidateEducationResponse>> SelectSingleAsync(Common.CandidateEducationSelectSingle Model);
	}
}