namespace Mytra.Business
{
    public class ManagementSettingsMapper : AutoMapper.Profile
    {
        public ManagementSettingsMapper()
        {
            CreateMap<Core.ManagementSettingsInsertDataTransfer, Core.ManagementSettings>();
            CreateMap<Core.ManagementSettingsUpdateDataTransfer, Core.ManagementSettings>();
            CreateMap<Core.ManagementSettingsDeleteDataTransfer, Core.ManagementSettings>();
            CreateMap<Core.ManagementSettingsSelectDataTransfer, Core.ManagementSettings>();
            CreateMap<Core.ManagementSettingsAnyDataTransfer, Core.ManagementSettings>();
        }
    }
}