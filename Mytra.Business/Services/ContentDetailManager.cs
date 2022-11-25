namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ContentDetailManager : IContentDetailService, IDisposable
    {
        protected IMapper Mapper;
        public ContentDetailManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}