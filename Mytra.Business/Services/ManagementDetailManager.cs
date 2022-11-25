namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ManagementDetailManager : IManagementDetailService, IDisposable
    {
        protected IMapper Mapper;
        public ManagementDetailManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}