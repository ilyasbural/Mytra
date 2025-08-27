namespace Mytra.DataAccess
{
    using Core;

    public class UnitOfWork : IUnitOfWork
    {
		public ICandidateAuthentication CandidateAuthentication => throw new NotImplementedException();
		public ICandidate Candidate => CandidateRepository ?? new CandidateRepositoryEF(DbContext);
		public ICandidateCertificate Certificate => throw new NotImplementedException();
		public ICandidateContact CandidateContact => throw new NotImplementedException();
		public ICandidateDetail CandidateDetail => throw new NotImplementedException();
		public ICandidateEducation CandidateEducation => throw new NotImplementedException();
		public ICandidateExperience CandidateExperience => throw new NotImplementedException();
		public ICandidateLanguage CandidateLanguage => throw new NotImplementedException();
		public ICandidatePhoto CandidatePhoto => throw new NotImplementedException();
		public ICandidateReferance CandidateReferance => throw new NotImplementedException();
		public ICandidateSettings CandidateSettings => throw new NotImplementedException();
		public ICandidateSkills CandidateSkills => throw new NotImplementedException();
		public ICollege College => throw new NotImplementedException();
		public IJobPostingApply JobPostingApply => JobPostingApplyRepository = new JobPostingApplyRepositoryEF(DbContext);
		public IJobPostingDetail JobPostingDetail => JobPostingDetailRepository = new JobPostingDetailRepositoryEF(DbContext);
		public IJobPosting JobPosting => JobPostingRepository ?? new JobPostingRepositoryEF(DbContext);
		public IJobPostingVisit JobPostingVisit => JobPostingVisitRepository = new JobPostingVisitRepositoryEF(DbContext);
		public IInstitution Institution => throw new NotImplementedException();
		public ILanguage Language => throw new NotImplementedException();
		public ISkills Skills => throw new NotImplementedException();
		public IManager Manager => throw new NotImplementedException();
		public IManagerAuthentication ManagerAuthentication => throw new NotImplementedException();
		public IManagerDetail ManagerDetail => throw new NotImplementedException();
		public IManagerSettings ManagerSettings => throw new NotImplementedException();
		public IUser User => UserRepository ?? new UserRepositoryEF(DbContext);
		public IUserAuthentication UserAuthentication => throw new NotImplementedException();
		public IUserDetail UserDetail => throw new NotImplementedException();
		public IUserSettings UserSettings => throw new NotImplementedException();

		MytraContext DbContext;
		public UnitOfWork(MytraContext dbContext)
        {
            DbContext = dbContext;
        }

		protected CandidateAuthenticationRepositoryEF CandidateAuthenticationRepository { get; set; } = null!;
		protected CandidateCertificateRepositoryEF CandidateCertificateRepository { get; set; } = null!;
		protected CandidateContactRepositoryEF CandidateContactRepository { get; set; } = null!;
		protected CandidateDetailRepositoryEF CandidateDetailRepository { get; set; } = null!;
		protected CandidateEducationRepositoryEF CandidateEducationRepository { get; set; } = null!;
		protected CandidateExperienceRepositoryEF CandidateExperienceRepository { get; set; } = null!;
		protected CandidateLanguageRepositoryEF CandidateLanguageRepository { get; set; } = null!;
		protected CandidatePhotoRepositoryEF CandidatePhotoRepository { get; set; } = null!;
		protected CandidateReferanceRepositoryEF CandidateReferanceRepository { get; set; } = null!;
		protected CandidateRepositoryEF CandidateRepository { get; set; } = null!;
		protected CandidateSettingsRepositoryEF CandidateSettingsRepository { get; set; } = null!;
		protected CandidateSkillsRepositoryEF CandidateSkillsRepository { get; set; } = null!;
		protected CollegeRepositoryEF CollegeRepository { get; set; } = null!;
		protected InstitutionRepositoryEF InstitutionRepository { get; set; } = null!;
		protected JobPostingApplyRepositoryEF JobPostingApplyRepository { get; set; } = null!;
		protected JobPostingDetailRepositoryEF JobPostingDetailRepository { get; set; } = null!;
		protected JobPostingRepositoryEF JobPostingRepository { get; set; } = null!;
		protected JobPostingVisitRepositoryEF JobPostingVisitRepository { get; set; } = null!;
		protected LanguageRepositoryEF LanguageRepository { get; set; } = null!;
		protected ManagerAuthenticationRepositoryEF ManagerAuthenticationRepository { get; set; } = null!;
		protected ManagerDetailRepositoryEF ManagerDetailRepository { get; set; } = null!;
		protected ManagerRepositoryEF ManagerRepository { get; set; } = null!;
		protected ManagerSettingsRepositoryEF ManagerSettingsRepository { get; set; } = null!;
		protected SkillsRepositoryEF SkillsRepository { get; set; } = null!;
		protected UserAuthenticationRepositoryEF UserAuthenticationRepository { get; set; } = null!;
		protected UserDetailRepositoryEF UserDetailRepository { get; set; } = null!;
		protected UserRepositoryEF UserRepository { get; set; } = null!;
		protected UserSettingsRepositoryEF UserSettingsRepository { get; set; } = null!;

		public async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await DbContext.DisposeAsync();
        }
    }
}