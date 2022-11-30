namespace Mytra.DataAccess
{
    using Core;

    public class UnitOfWork : IUnitOfWork
    {
        private MytraContext DbContext { get; set; }
        public IAnnounceDetailRepository AnnounceDetail => AnnounceDetailRepository ?? new AnnounceDetailRepositoryEF(DbContext);
        //public IAnnounce Announce => AnnounceRepository ?? new AnnounceRepositoryEF(DbContext);
        //public IAnnounceDetail AnnounceDetail => AnnounceDetailRepository ?? new AnnounceDetailRepositoryEF(DbContext);
        //public IAppeal Appeal => AppealRepository ?? new AppealRepositoryEF(DbContext);
        //public IAppealDetail AppealDetail => AppealDetailRepository ?? new AppealDetailRepositoryEF(DbContext);
        //public ICertificate Certificate => CertificateRepository ?? new CertificateRepositoryEF(DbContext);
        //public ICollege College => CollegeRepository ?? new CollegeRepositoryEF(DbContext);
        //public ICompany Company => CompanyRepository ?? new CompanyRepositoryEF(DbContext);
        //public ICompanyAbout CompanyAbout => CompanyAboutRepository ?? new CompanyAboutRepositoryEF(DbContext);
        //public ICompanyDetail CompanyDetail => CompanyDetailRepository ?? new CompanyDetailRepositoryEF(DbContext);
        //public ICompanyFollower CompanyFollower => CompanyFollowerRepository ?? new CompanyFollowerRepositoryEF(DbContext);
        //public ICompanySettings CompanySettings => CompanySettingsRepository ?? new CompanySettingsRepositoryEF(DbContext);
        //public ICompanyVideo CompanyVideo => CompanyVideoRepository ?? new CompanyVideoRepositoryEF(DbContext);
        //public IManagement Management => ManagementRepository ?? new ManagementRepositoryEF(DbContext);
        //public IManagementDetail ManagementDetail => ManagementDetailRepository ?? new ManagementDetailRepositoryEF(DbContext);
        //public INetwork Network => NetworkRepository ?? new NetworkRepositoryEF(DbContext);
        //public IMessageBox MessageBox => MessageBoxRepository ?? new MessageBoxRepositoryEF(DbContext);
        //public IOccupation Occupation => OccupationRepository ?? new OccupationRepositoryEF(DbContext);
        //public IPosition Position => PositionRepository ?? new PositionRepositoryEF(DbContext);
        //public IRegion Region => RegionRepository ?? new RegionRepositoryEF(DbContext);
        //public ISurvey Survey => SurveyRepository ?? new SurveyRepositoryEF(DbContext);
        //public IUser User => UserRepository ?? new UserRepositoryEF(DbContext);
        //public IUserAbility UserAbility => UserAbilityRepository ?? new UserAbilityRepositoryEF(DbContext);
        //public IUserAbout UserAbout => UserAboutRepository ?? new UserAboutRepositoryEF(DbContext);
        //public IUserCertificate UserCertificate => UserCertificateRepository ?? new UserCertificateRepositoryEF(DbContext);
        //public IUserDetail UserDetail => UserDetailRepository ?? new UserDetailRepositoryEF(DbContext);
        //public IUserEducation UserEducation => UserEducationRepository ?? new UserEducationRepositoryEF(DbContext);
        //public IUserExperience UserExperience => UserExperienceRepository ?? new UserExperienceRepositoryEF(DbContext);
        //public IUserFollower UserFollower => UserFollowerRepository ?? new UserFollowerRepositoryEF(DbContext);
        //public IUserLanguage UserLanguage => UserLanguageRepository ?? new UserLanguageRepositoryEF(DbContext);
        //public IUserReferance UserReferance => UserReferanceRepository ?? new UserReferanceRepositoryEF(DbContext);
        //public IUserSettings UserSettings => UserSettingsRepository ?? new UserSettingsRepositoryEF(DbContext);
        //public IUserVideo UserVideo => UserVideoRepository ?? new UserVideoRepositoryEF(DbContext);

        public UnitOfWork(MytraContext dbContext)
        {
            DbContext = dbContext;
        }

        protected AnnounceDetailRepositoryEF AnnounceDetailRepository { get; set; } = null!;
        protected AnnounceRepositoryEF AnnounceRepository { get; set; } = null!;
        protected CategoryRepositoryEF CategoryRepository { get; set; } = null!;
        protected ContentCommentRepositoryEF ContentCommentRepository { get; set; } = null!;
        protected ContentDetailRepositoryEF ContentDetailRepository { get; set; } = null!;
        protected ContentLikeRepositoryEF ContentLikeRepository { get; set; } = null!;
        protected ContentPictureRepositoryEF CompanyAboutRepository { get; set; } = null!;
        protected ContentRepositoryEF CompanyRepository { get; set; } = null!;
        protected ContentSettingsRepositoryEF CompanyDetailRepository { get; set; } = null!;
        protected ContentTypeRepositoryEF CompanyFollowerRepository { get; set; } = null!;
        protected ManagementContactRepositoryEF CompanySettingsRepository { get; set; } = null!;
        protected ManagementDetailRepositoryEF CompanyVideoRepository { get; set; } = null!;
        protected ManagementRepositoryEF ManagementRepository { get; set; } = null!;
        protected ManagementSettingsRepositoryEF ManagementDetailRepository { get; set; } = null!;
        protected PermissionDetailRepositoryEF MessageBoxRepository { get; set; } = null!;
        protected PermissionRepositoryEF NetworkRepository { get; set; } = null!;
        protected SurveyDetailRepositoryEF OccupationRepository { get; set; } = null!;
        protected SurveyRepositoryEF PositionRepository { get; set; } = null!;
        protected UserContactRepositoryEF RegionRepository { get; set; } = null!;
        protected UserDetailRepositoryEF SurveyRepository { get; set; } = null!;
        protected UserEmailRepositoryEF UserRepository { get; set; } = null!;
        protected UserRepositoryEF UserAbilityRepository { get; set; } = null!;
        protected UserSettingsRepositoryEF UserSettingsRepository { get; set; } = null!;
    }
}