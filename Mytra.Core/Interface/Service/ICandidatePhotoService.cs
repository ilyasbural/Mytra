namespace Mytra.Core
{
    public interface ICandidatePhotoService
    {
		Task<Common.ServiceResponse<Common.CandidatePhotoResponse>> InsertAsync(Common.CandidatePhotoInsert Model);
		Task<Common.ServiceResponse<Common.CandidatePhotoResponse>> UpdateAsync(Common.CandidatePhotoUpdate Model);
		Task<Common.ServiceResponse<Common.CandidatePhotoResponse>> DeleteAsync(Common.CandidatePhotoDelete Model);
		Task<Common.ServiceResponse<Common.CandidatePhotoResponse>> SelectAsync(Common.CandidatePhotoSelect Model);
		Task<Common.ServiceResponse<Common.CandidatePhotoResponse>> SelectSingleAsync(Common.CandidatePhotoSelectSingle Model);
	}
}