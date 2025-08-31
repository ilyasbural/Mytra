namespace Mytra.Core
{
    public interface IJobPostingService
    {
		Task<Common.DataService<JobPosting>> InsertAsync(Common.JobPostingInsert Model);
		Task<Common.DataService<JobPosting>> UpdateAsync(Common.JobPostingUpdate Model);
		Task<Common.DataService<JobPosting>> DeleteAsync(Common.JobPostingDelete Model);
		Task<Common.DataService<JobPosting>> SelectAsync(Common.JobPostingSelect Model);
		Task<Common.DataService<JobPosting>> SelectSingleAsync(Common.JobPostingSelectSingle Model);
	}
}