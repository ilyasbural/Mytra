namespace Mytra.Business
{
    public class ContentDetailMapper : AutoMapper.Profile
    {
        public ContentDetailMapper()
        {
            CreateMap<Core.ContentDetailInsertDataTransfer, Core.ContentDetail>();
            CreateMap<Core.ContentDetailUpdateDataTransfer, Core.ContentDetail>();
            CreateMap<Core.ContentDetailDeleteDataTransfer, Core.ContentDetail>();
            CreateMap<Core.ContentDetailSelectDataTransfer, Core.ContentDetail>();
            CreateMap<Core.ContentDetailAnyDataTransfer, Core.ContentDetail>();
        }
    }
}