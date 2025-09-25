namespace Mytra.Core
{
    public interface IJobPostingVisitService
    {
		Task<Utilize.DataService<JobPostingVisit>> InsertAsync(Utilize.JobPostingVisitInsert Model);
		Task<Utilize.DataService<JobPostingVisit>> UpdateAsync(Utilize.JobPostingVisitUpdate Model);
		Task<Utilize.DataService<JobPostingVisit>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<JobPostingVisit>> SelectAsync(Utilize.JobPostingVisitSelect Model);
		Task<Utilize.DataService<JobPostingVisit>> SelectSingleAsync(Utilize.JobPostingVisitSelectSingle Model);
	}
}