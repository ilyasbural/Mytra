namespace Mytra.Core
{
    public interface IJobPostingVisitService
    {
		Task<Common.DataService<JobPostingVisit>> InsertAsync(Common.JobPostingVisitInsert Model);
		Task<Common.DataService<JobPostingVisit>> UpdateAsync(Common.JobPostingVisitUpdate Model);
		Task<Common.DataService<JobPostingVisit>> DeleteAsync(Common.JobPostingVisitDelete Model);
		Task<Common.DataService<JobPostingVisit>> SelectAsync(Common.JobPostingVisitSelect Model);
		Task<Common.DataService<JobPostingVisit>> SelectSingleAsync(Common.JobPostingVisitSelectSingle Model);
	}
}