namespace Mytra.Business
{
    public class ManagementSettingsMapper : AutoMapper.Profile
    {
        public ManagementSettingsMapper()
        {
            CreateMap<Core.ManagementSettingsInsertDataTransfer, Core.ManagementSettings>();
            CreateMap<Core.ManagementSettingsUpdateDataTransfer, Core.ManagementSettings>();
        }
    }
}