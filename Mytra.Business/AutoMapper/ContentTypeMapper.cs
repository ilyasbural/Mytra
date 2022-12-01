namespace Mytra.Business
{
    public class ContentTypeMapper : AutoMapper.Profile 
    {
        public ContentTypeMapper()
        {
            CreateMap<Core.ContentTypeInsertDataTransfer, Core.ContentType>();
        }
    }
}