namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ContentLikeManager : IContentLikeService, IDisposable
    {
        protected IMapper Mapper;
        public ContentLikeManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}