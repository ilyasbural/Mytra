namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ContentManager : IContentService, IDisposable
    {
        protected IMapper Mapper;
        public ContentManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}