namespace Mytra.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IAnnounce Announce { get; }
        IAnnounceDetail AnnounceDetail { get; }
        ICategory Category { get; }
        IContent Content { get; }
        IContentComment ContentComment { get; }
        IContentDetail ContentDetail { get; }
        IContentLike ContentLike { get; }
        IContentPicture ContentPicture { get; }
        IContentSettings ContentSettings { get; }
        IContentType ContentType { get; }
        IManagement Management { get; }
        IManagementContact ManagementContact { get; }
        IManagementDetail ManagementDetail { get; }
        IManagementSettings ManagementSettings { get; }
        IPermission Permission { get; }
        IPermissionDetail PermissionDetail { get; }
        ISurvey Survey { get; }
        IUser User { get; }
        IUserContact UserContact { get; }
        IUserDetail UserDetail { get; }
        IUserEmail UserEmail { get; }
        IUserSettings UserSettings { get; }
        Task<int> SaveAsync();
    }
}