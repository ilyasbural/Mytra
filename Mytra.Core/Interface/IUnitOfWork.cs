﻿namespace Mytra.Core
{
    public interface IUnitOfWork : IDisposable
    {
		ICandidate Candidate { get; }
		ICandidateAuthentication Authentication { get; }
		ICandidateCertificate Certificate { get; }
        ICandidateContact CandidateContact { get; }
        ICandidateDetail CandidateDetail { get; }
        ICandidateEducation CandidateEducation { get; }
        ICandidateExperience CandidateExperience { get; }
        ICandidateLanguage CandidateLanguage { get; }
        ICandidatePhoto CandidatePhoto { get; }
        ICandidateReferance CandidateReferance { get; }
        ICandidateSettings CandidateSettings { get; }
        ICandidateSkills CandidateSkills { get; }
        ICollege College { get; }
		IJobPostingApply JobPostingApply { get; }
		IJobPostingDetail JobPostingDetail { get; }
		IJobPosting JobPosting { get; }
        IJobPostingVisit JobPostingVisit { get; }
        IInstitution Institution { get; }
        ILanguage Language { get; }
        IManager Manager { get; }
        IManagerAuthentication ManagerAuthentication { get; }
        IManagerDetail ManagerDetail { get; }
        IManagerSettings ManagerSettings { get; }
        ISkills Skills { get; }
        IUser User { get; }
        IUserAuthentication UserAuthentication { get; }
        IUserDetail UserDetail { get; }
        IUserSettings UserSettings { get; }
		Task<int> SaveChangesAsync();
    }
}