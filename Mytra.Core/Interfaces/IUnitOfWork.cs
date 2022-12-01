namespace Mytra.Core
{
    public interface IUnitOfWork
    {
        IAnnounceRepository Announce { get; }
        IAnnounceDetailRepository AnnounceDetail { get; }
        ICategoryRepository Category { get; }
        IContentCommentRepository ContentComment { get; }
        IContentDetailRepository ContentDetail { get; }
        IContentLikeRepository ContentLike { get; }
        IContentRepository Content { get; }
        IContentPictureRepository ContentPicture { get; }
        IContentSettingsRepository ContentSettings { get; }
        IContentTypeRepository ContentType { get; }
        IManagementContactRepository ManagementContact { get; }
        IManagementDetailRepository ManagementDetail { get; }
        IManagementRepository Management { get; }
        IManagementSettingsRepository ManagementSettings { get; }
        IPermissionRepository Permission { get; }
        IPermissionDetailRepository PermissionDetail { get; }
        ISurveyRepository Survey { get; }
        ISurveyDetailRepository SurveyDetail { get; }
        IUserContactRepository UserContact { get; }
        IUserDetailRepository UserDetail { get; }
        IUserEmailRepository UserEmail { get; }
        IUserRepository User { get; }
        IUserSettingsRepository UserSettings { get; }
        Task<int> SaveChangesAsync();
    }
}