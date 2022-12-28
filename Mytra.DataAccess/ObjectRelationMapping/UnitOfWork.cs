namespace Mytra.DataAccess
{
    using Core;

    public class UnitOfWork : IUnitOfWork
    {
        MytraContext DbContext;

        public IAnnounceRepository Announce => AnnounceRepository ?? new AnnounceRepositoryEF(DbContext);
        public IAnnounceDetailRepository AnnounceDetail => AnnounceDetailRepository ?? new AnnounceDetailRepositoryEF(DbContext);
        public ICategoryRepository Category => CategoryRepository ?? new CategoryRepositoryEF(DbContext);
        public IContentCommentRepository ContentComment => ContentCommentRepository ?? new ContentCommentRepositoryEF(DbContext);
        public IContentDetailRepository ContentDetail => ContentDetailRepository ?? new ContentDetailRepositoryEF(DbContext);
        public IContentLikeRepository ContentLike => ContentLikeRepository ?? new ContentLikeRepositoryEF(DbContext);
        public IContentRepository Content => ContentRepository ?? new ContentRepositoryEF(DbContext);
        public IContentPictureRepository ContentPicture => ContentPictureRepository ?? new ContentPictureRepositoryEF(DbContext);
        public IContentSettingsRepository ContentSettings => ContentSettingsRepository ?? new ContentSettingsRepositoryEF(DbContext);
        public IContentTypeRepository ContentType => ContentTypeRepository ?? new ContentTypeRepositoryEF(DbContext);
        public IManagementContactRepository ManagementContact => ManagementContactRepository ?? new ManagementContactRepositoryEF(DbContext);
        public IManagementDetailRepository ManagementDetail => ManagementDetailRepository ?? new ManagementDetailRepositoryEF(DbContext);
        public IManagementRepository Management => ManagementRepository ?? new ManagementRepositoryEF(DbContext);
        public IManagementSettingsRepository ManagementSettings => ManagementSettingsRepository ?? new ManagementSettingsRepositoryEF(DbContext);
        public IPermissionRepository Permission => PermissionRepository ?? new PermissionRepositoryEF(DbContext);
        public IPermissionDetailRepository PermissionDetail => PermissionDetailRepository ?? new PermissionDetailRepositoryEF(DbContext);
        public ISurveyRepository Survey => SurveyRepository ?? new SurveyRepositoryEF(DbContext);
        public ISurveyDetailRepository SurveyDetail => SurveyDetailRepository ?? new SurveyDetailRepositoryEF(DbContext);
        public IUserContactRepository UserContact => UserContactRepository ?? new UserContactRepositoryEF(DbContext);
        public IUserDetailRepository UserDetail => UserDetailRepository ?? new UserDetailRepositoryEF(DbContext);
        public IUserEmailRepository UserEmail => UserEmailRepository ?? new UserEmailRepositoryEF(DbContext);
        public IUserRepository User => UserRepository ?? new UserRepositoryEF(DbContext);
        public IUserSettingsRepository UserSettings => UserSettingsRepository ?? new UserSettingsRepositoryEF(DbContext);

        public UnitOfWork(MytraContext dbContext)
        {
            DbContext = dbContext;
        }

        protected AnnounceRepositoryEF AnnounceRepository { get; set; } = null!;
        protected AnnounceDetailRepositoryEF AnnounceDetailRepository { get; set; } = null!;
        protected CategoryRepositoryEF CategoryRepository { get; set; } = null!;
        protected ContentCommentRepositoryEF ContentCommentRepository { get; set; } = null!;
        protected ContentDetailRepositoryEF ContentDetailRepository { get; set; } = null!;
        protected ContentLikeRepositoryEF ContentLikeRepository { get; set; } = null!;
        protected ContentPictureRepositoryEF ContentPictureRepository { get; set; } = null!;
        protected ContentRepositoryEF ContentRepository { get; set; } = null!;
        protected ContentSettingsRepositoryEF ContentSettingsRepository { get; set; } = null!;
        protected ContentTypeRepositoryEF ContentTypeRepository { get; set; } = null!;
        protected ManagementContactRepositoryEF ManagementContactRepository { get; set; } = null!;
        protected ManagementDetailRepositoryEF ManagementDetailRepository { get; set; } = null!;
        protected ManagementRepositoryEF ManagementRepository { get; set; } = null!;
        protected ManagementSettingsRepositoryEF ManagementSettingsRepository { get; set; } = null!;
        protected PermissionRepositoryEF PermissionRepository { get; set; } = null!;
        protected PermissionDetailRepositoryEF PermissionDetailRepository { get; set; } = null!;
        protected SurveyRepositoryEF SurveyRepository { get; set; } = null!;
        protected SurveyDetailRepositoryEF SurveyDetailRepository { get; set; } = null!;
        protected UserContactRepositoryEF UserContactRepository { get; set; } = null!;
        protected UserDetailRepositoryEF UserDetailRepository { get; set; } = null!;
        protected UserEmailRepositoryEF UserEmailRepository { get; set; } = null!;
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