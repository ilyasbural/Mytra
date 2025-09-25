namespace Mytra.Service
{
	public class ManagerSettingsMapper : AutoMapper.Profile
	{
		public ManagerSettingsMapper()
		{
			CreateMap<Utilize.ManagerSettingsInsert, Core.ManagerSettings>().ReverseMap();
			CreateMap<Utilize.ManagerSettingsUpdate, Core.ManagerSettings>().ReverseMap();
			CreateMap<Utilize.ManagerSettingsSelect, Core.ManagerSettings>().ReverseMap();
			CreateMap<Utilize.ManagerSettingsSelectSingle, Core.ManagerSettings>().ReverseMap();
			CreateMap<Utilize.ManagerSettingsResponse, Core.ManagerSettings>().ReverseMap();
		}
	}
}