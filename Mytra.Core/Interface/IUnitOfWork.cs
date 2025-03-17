namespace Mytra.Core
{
    public interface IUnitOfWork : IDisposable
    {
		ICandidate Candidate { get; }
		ICandidateAuthentication Authentication { get; }
		ICandidateCertificate Certificate { get; }
		ICollege College { get; }
		IJobPostingApply JobPostingApply { get; }
		IJobPostingDetail JobPostingDetail { get; }
		IJobPosting JobPosting { get; }
		ILanguage Language { get; }		
		IUserDetail UserDetail { get; }
		IUser User { get; }
		IUserSettings UserSettings { get; }
		Task<int> SaveChangesAsync();
    }
}