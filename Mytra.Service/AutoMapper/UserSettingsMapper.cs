namespace Mytra.Service
{
    public class UserSettingsMapper : AutoMapper.Profile
    {
        public UserSettingsMapper()
        {
            CreateMap<Core.UserSettingsInsertDataTransfer, Core.UserSettings>();
            CreateMap<Core.UserSettingsUpdateDataTransfer, Core.UserSettings>();
            CreateMap<Core.UserSettingsDeleteDataTransfer, Core.UserSettings>();
            CreateMap<Core.UserSettingsSelectDataTransfer, Core.UserSettings>();
            CreateMap<Core.UserSettingsAnyDataTransfer, Core.UserSettings>();
        }
    }
}