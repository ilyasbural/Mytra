namespace Mytra.Business
{
    public class ContentTypeMapper : AutoMapper.Profile 
    {
        public ContentTypeMapper()
        {
            CreateMap<Core.ContentTypeInsertDataTransfer, Core.ContentType>();
            CreateMap<Core.ContentTypeUpdateDataTransfer, Core.ContentType>();
            CreateMap<Core.ContentTypeDeleteDataTransfer, Core.ContentType>();
            CreateMap<Core.ContentTypeSelectDataTransfer, Core.ContentType>();
            CreateMap<Core.ContentTypeAnyDataTransfer, Core.ContentType>();
        }
    }
}