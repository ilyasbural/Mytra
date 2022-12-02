namespace Mytra.Business
{
    public class ContentSettingsMapper : AutoMapper.Profile 
    {
        public ContentSettingsMapper()
        {
            CreateMap<Core.ContentSettingsInsertDataTransfer, Core.ContentSettings>();
            CreateMap<Core.ContentSettingsUpdateDataTransfer, Core.ContentSettings>();
            CreateMap<Core.ContentSettingsDeleteDataTransfer, Core.ContentSettings>();
            CreateMap<Core.ContentSettingsSelectDataTransfer, Core.ContentSettings>();
            CreateMap<Core.ContentSettingsAnyDataTransfer, Core.ContentSettings>();
        }
    }
}