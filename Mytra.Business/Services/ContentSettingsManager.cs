namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class ContentSettingsManager : IContentSettingsService, IDisposable
    {
        protected IMapper Mapper;
        public ContentSettingsManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}