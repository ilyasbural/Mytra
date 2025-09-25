namespace Mytra.Core
{
    public interface IJobPostingDetailService
    {
		Task<Utilize.DataService<JobPostingDetail>> InsertAsync(Utilize.JobPostingDetailInsert Model);
		Task<Utilize.DataService<JobPostingDetail>> UpdateAsync(Utilize.JobPostingDetailUpdate Model);
		Task<Utilize.DataService<JobPostingDetail>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<JobPostingDetail>> SelectAsync(Utilize.JobPostingDetailSelect Model);
		Task<Utilize.DataService<JobPostingDetail>> SelectSingleAsync(Utilize.JobPostingDetailSelectSingle Model);
	}
}