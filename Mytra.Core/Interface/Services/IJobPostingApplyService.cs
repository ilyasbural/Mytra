namespace Mytra.Core
{
    public interface IJobPostingApplyService
    {
		Task<Utilize.DataService<JobPostingApply>> InsertAsync(Utilize.JobPostingApplyInsert Model);
		Task<Utilize.DataService<JobPostingApply>> UpdateAsync(Utilize.JobPostingApplyUpdate Model);
		Task<Utilize.DataService<JobPostingApply>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<JobPostingApply>> SelectAsync(Utilize.JobPostingApplySelect Model);
		Task<Utilize.DataService<JobPostingApply>> SelectSingleAsync(Utilize.JobPostingApplySelectSingle Model);
	}
}