namespace Mytra.Core
{
    public interface IJobPostingDetailService
    {
		Task<Common.DataService<JobPostingDetail>> InsertAsync(Common.JobPostingDetailInsert Model);
		Task<Common.DataService<JobPostingDetail>> UpdateAsync(Common.JobPostingDetailUpdate Model);
		Task<Common.DataService<JobPostingDetail>> DeleteAsync(Guid Id);
		Task<Common.DataService<JobPostingDetail>> SelectAsync(Common.JobPostingDetailSelect Model);
		Task<Common.DataService<JobPostingDetail>> SelectSingleAsync(Common.JobPostingDetailSelectSingle Model);
	}
}