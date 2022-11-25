namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ManagementContactManager : IManagementContactService, IDisposable
    {
        protected IMapper Mapper;
        public ManagementContactManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}