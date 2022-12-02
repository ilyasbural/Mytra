namespace Mytra.Business
{
    public class ContentSettingsMapper : AutoMapper.Profile 
    {
        public ContentSettingsMapper()
        {
            CreateMap<Core.ContentSettingsInsertDataTransfer, Core.ContentSettings>();
            CreateMap<Core.ContentSettingsUpdateDataTransfer, Core.ContentSettings>();
        }
    }
}