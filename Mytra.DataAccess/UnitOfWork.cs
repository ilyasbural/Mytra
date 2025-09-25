namespace Mytra.DataAccess
{
    using Core;

    public class UnitOfWork : IUnitOfWork
    {
		public ICandidateAuthentication CandidateAuthentication => CandidateAuthenticationRepository ?? new CandidateAuthenticationRepositoryEF(DbContext);
		public ICandidateCertificate CandidateCertificate => CandidateCertificateRepository ?? new CandidateCertificateRepositoryEF(DbContext);
		public ICandidateContact CandidateContact => CandidateContactRepository ?? new CandidateContactRepositoryEF(DbContext);
		public ICandidateDetail CandidateDetail => CandidateDetailRepository ?? new CandidateDetailRepositoryEF(DbContext);
		public ICandidateEducation CandidateEducation => CandidateEducationRepository ?? new CandidateEducationRepositoryEF(DbContext);
		public ICandidateExperience CandidateExperience => CandidateExperienceRepository ?? new CandidateExperienceRepositoryEF(DbContext);
		public ICandidateLanguage CandidateLanguage => CandidateLanguageRepository ?? new CandidateLanguageRepositoryEF(DbContext);
		public ICandidatePhoto CandidatePhoto => CandidatePhotoRepository ?? new CandidatePhotoRepositoryEF(DbContext);
		public ICandidateReferance CandidateReferance => CandidateReferanceRepository ?? new CandidateReferanceRepositoryEF(DbContext);
		public ICandidate Candidate => CandidateRepository ?? new CandidateRepositoryEF(DbContext);
		public ICandidateSettings CandidateSettings => CandidateSettingsRepository ?? new CandidateSettingsRepositoryEF(DbContext);
		public ICandidateSkills CandidateSkills => CandidateSkillsRepository ?? new CandidateSkillsRepositoryEF(DbContext);
		public ICollege College => CollegeRepository ?? new CollegeRepositoryEF(DbContext);
		public IJobPostingApply JobPostingApply => JobPostingApplyRepository = new JobPostingApplyRepositoryEF(DbContext);
		public IJobPostingDetail JobPostingDetail => JobPostingDetailRepository = new JobPostingDetailRepositoryEF(DbContext);
		public IJobPosting JobPosting => JobPostingRepository ?? new JobPostingRepositoryEF(DbContext);
		public IJobPostingVisit JobPostingVisit => JobPostingVisitRepository = new JobPostingVisitRepositoryEF(DbContext);
		public IInstitution Institution => InstitutionRepository ?? new InstitutionRepositoryEF(DbContext);
		public ILanguage Language => LanguageRepository ?? new LanguageRepositoryEF(DbContext);
		public ISkills Skills => SkillsRepository ?? new SkillsRepositoryEF(DbContext);
		public IManager Manager => ManagerRepository ?? new ManagerRepositoryEF(DbContext);
		public IManagerAuthentication ManagerAuthentication => ManagerAuthenticationRepository ?? new ManagerAuthenticationRepositoryEF(DbContext);
		public IManagerDetail ManagerDetail => ManagerDetailRepository ?? new ManagerDetailRepositoryEF(DbContext);
		public IManagerSettings ManagerSettings => ManagerSettingsRepository ?? new ManagerSettingsRepositoryEF(DbContext);
		public IUser User => UserRepository ?? new UserRepositoryEF(DbContext);
		public IUserAuthentication UserAuthentication => UserAuthenticationRepository ?? new UserAuthenticationRepositoryEF(DbContext);
		public IUserDetail UserDetail => UserDetailRepository ?? new UserDetailRepositoryEF(DbContext);
		public IUserSettings UserSettings => UserSettingsRepository ?? new UserSettingsRepositoryEF(DbContext);

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