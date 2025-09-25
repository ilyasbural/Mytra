namespace Mytra.Core
{
    public interface IJobPostingService
    {
		Task<Utilize.DataService<JobPosting>> InsertAsync(Utilize.JobPostingInsert Model);
		Task<Utilize.DataService<JobPosting>> UpdateAsync(Utilize.JobPostingUpdate Model);
		Task<Utilize.DataService<JobPosting>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<JobPosting>> SelectAsync(Utilize.JobPostingSelect Model);
		Task<Utilize.DataService<JobPosting>> SelectSingleAsync(Utilize.JobPostingSelectSingle Model);
	}
}