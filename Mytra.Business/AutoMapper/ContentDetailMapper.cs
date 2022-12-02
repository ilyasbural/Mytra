namespace Mytra.Business
{
    public class ContentDetailMapper : AutoMapper.Profile
    {
        public ContentDetailMapper()
        {
            CreateMap<Core.ContentDetailInsertDataTransfer, Core.ContentDetail>();
            CreateMap<Core.ContentDetailUpdateDataTransfer, Core.ContentDetail>();
        }
    }
}