namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class UserSettingsManager : IUserSettingsService, IDisposable
    {
        protected IMapper Mapper;
        public UserSettingsManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}