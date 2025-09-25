namespace Mytra.Service
{
	public class UserSettingsMapper : AutoMapper.Profile
	{
		public UserSettingsMapper()
		{
			CreateMap<Utilize.UserSettingsInsert, Core.UserSettings>().ReverseMap();
			CreateMap<Utilize.UserSettingsUpdate, Core.UserSettings>().ReverseMap();
			CreateMap<Utilize.UserSettingsSelect, Core.UserSettings>().ReverseMap();
			CreateMap<Utilize.UserSettingsSelectSingle, Core.UserSettings>().ReverseMap();
			CreateMap<Utilize.UserSettingsResponse, Core.UserSettings>().ReverseMap();
		}
	}
}