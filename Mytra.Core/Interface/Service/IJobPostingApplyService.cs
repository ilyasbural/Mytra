namespace Mytra.Core
{
    public interface IJobPostingApplyService
    {
		Task<Common.DataService<JobPostingApply>> InsertAsync(Common.JobPostingApplyInsert Model);
		Task<Common.DataService<JobPostingApply>> UpdateAsync(Common.JobPostingApplyUpdate Model);
		Task<Common.DataService<JobPostingApply>> DeleteAsync(Common.JobPostingApplyDelete Model);
		Task<Common.DataService<JobPostingApply>> SelectAsync(Common.JobPostingApplySelect Model);
		Task<Common.DataService<JobPostingApply>> SelectSingleAsync(Common.JobPostingApplySelectSingle Model);
	}
}