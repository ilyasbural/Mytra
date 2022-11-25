namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ContentTypeManager : IContentTypeService, IDisposable
    {
        protected IMapper Mapper;
        public ContentTypeManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}