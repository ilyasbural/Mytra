namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ContentCommentManager : IContentCommentService, IDisposable
    {
        protected IMapper Mapper;
        public ContentCommentManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}