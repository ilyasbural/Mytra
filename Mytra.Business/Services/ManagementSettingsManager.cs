namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ManagementSettingsManager : IManagementSettingsService, IDisposable
    {
        protected IMapper Mapper;
        public ManagementSettingsManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}