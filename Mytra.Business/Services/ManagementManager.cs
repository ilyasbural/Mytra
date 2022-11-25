namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ManagementManager : IManagementService
    {
        protected IMapper Mapper;
        public ManagementManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}