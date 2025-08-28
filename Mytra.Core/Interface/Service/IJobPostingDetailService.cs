namespace Mytra.Core
{
    public interface IJobPostingDetailService
    {
		Task<Common.ServiceResponse<Common.JobPostingDetailResponse>> InsertAsync(Common.JobPostingDetailInsert Model);
		Task<Common.ServiceResponse<Common.JobPostingDetailResponse>> UpdateAsync(Common.JobPostingDetailUpdate Model);
		Task<Common.ServiceResponse<Common.JobPostingDetailResponse>> DeleteAsync(Common.JobPostingDetailDelete Model);
		Task<Common.ServiceResponse<Common.JobPostingDetailResponse>> SelectAsync(Common.JobPostingDetailSelect Model);
		Task<Common.ServiceResponse<Common.JobPostingDetailResponse>> SelectSingleAsync(Common.JobPostingDetailSelectSingle Model);
	}
}