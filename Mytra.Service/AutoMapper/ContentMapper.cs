namespace Mytra.Service
{
    public class ContentMapper : AutoMapper.Profile
    {
        public ContentMapper()
        {
            CreateMap<Core.ContentInsertDataTransfer, Core.Content>();
            CreateMap<Core.ContentUpdateDataTransfer, Core.Content>();
            CreateMap<Core.ContentDeleteDataTransfer, Core.Content>();
            CreateMap<Core.ContentSelectDataTransfer, Core.Content>();
            CreateMap<Core.ContentAnyDataTransfer, Core.Content>();
        }
    }
}