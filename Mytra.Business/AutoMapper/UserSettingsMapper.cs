namespace Mytra.Business
{
    public class UserSettingsMapper : AutoMapper.Profile
    {
        public UserSettingsMapper()
        {
            CreateMap<Core.UserSettingsInsertDataTransfer, Core.UserSettings>();
            CreateMap<Core.UserSettingsUpdateDataTransfer, Core.UserSettings>();
        }
    }
}