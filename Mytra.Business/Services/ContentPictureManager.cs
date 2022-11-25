namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ContentPictureManager : IContentPictureService, IDisposable
    {
        protected IMapper Mapper;
        public ContentPictureManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}