namespace Mytra.Service
{
	public class UserSettingsMapper : AutoMapper.Profile
	{
		public UserSettingsMapper()
		{
			CreateMap<Common.UserSettingsInsert, Core.UserSettings>().ReverseMap();
			CreateMap<Common.UserSettingsUpdate, Core.UserSettings>().ReverseMap();
			CreateMap<Common.UserSettingsDelete, Core.UserSettings>().ReverseMap();
			CreateMap<Common.UserSettingsSelect, Core.UserSettings>().ReverseMap();
			CreateMap<Common.UserSettingsSelectSingle, Core.UserSettings>().ReverseMap();
		}
	}
}