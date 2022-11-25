namespace Mytra.DataAccess
{
    using Core;
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork
    {
        private MytraContext DbContext { get; set; }
        private AnnounceRepositoryEF AnnounceRepository;

        public UnitOfWork(MytraContext context) => DbContext = context;

        public IAnnounce Announce => AnnounceRepository ?? new AnnounceRepositoryEF(DbContext);
        public IAnnounceDetail AnnounceDetail => throw new NotImplementedException();
        public ICategory Category => throw new NotImplementedException();
        public IContent Content => throw new NotImplementedException();
        public IContentComment ContentComment => throw new NotImplementedException();
        public IContentDetail ContentDetail => throw new NotImplementedException();
        public IContentLike ContentLike => throw new NotImplementedException();
        public IContentPicture ContentPicture => throw new NotImplementedException();
        public IContentSettings ContentSettings => throw new NotImplementedException();
        public IContentType ContentType => throw new NotImplementedException();
        public IManagement Management => throw new NotImplementedException();
        public IManagementContact ManagementContact => throw new NotImplementedException();
        public IManagementDetail ManagementDetail => throw new NotImplementedException();
        public IManagementSettings ManagementSettings => throw new NotImplementedException();
        public IPermission Permission => throw new NotImplementedException();
        public IPermissionDetail PermissionDetail => throw new NotImplementedException();
        public ISurvey Survey => throw new NotImplementedException();
        public IUser User => throw new NotImplementedException();
        public IUserContact UserContact => throw new NotImplementedException();
        public IUserDetail UserDetail => throw new NotImplementedException();
        public IUserEmail UserEmail => throw new NotImplementedException();
        public IUserSettings UserSettings => throw new NotImplementedException();

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}