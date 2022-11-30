namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;

    public class UnitOfWork : IUnitOfWork
    {
        protected MytraContext DbContext;

        public IAnnounceRepository Announce => AnnounceRepository ?? new AnnounceRepositoryEF(DbContext);
        public IAnnounceDetailRepository AnnounceDetail => AnnounceDetailRepository ?? new AnnounceDetailRepositoryEF(DbContext);
        public ICategoryRepository Category => CategoryRepository ?? new CategoryRepositoryEF(DbContext);

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
    }
}