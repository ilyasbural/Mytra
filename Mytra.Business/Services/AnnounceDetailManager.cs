namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class AnnounceDetailManager : IAnnounceDetailService, IDisposable
    {
        protected IMapper Mapper;
        public AnnounceDetailManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}