namespace Mytra.Service
{
	public class ManagerSettingsMapper : AutoMapper.Profile
	{
		public ManagerSettingsMapper()
		{
			CreateMap<Common.ManagerSettingsInsert, Core.ManagerSettings>().ReverseMap();
			CreateMap<Common.ManagerSettingsUpdate, Core.ManagerSettings>().ReverseMap();
			CreateMap<Common.ManagerSettingsDelete, Core.ManagerSettings>().ReverseMap();
			CreateMap<Common.ManagerSettingsSelect, Core.ManagerSettings>().ReverseMap();
			CreateMap<Common.ManagerSettingsSelectSingle, Core.ManagerSettings>().ReverseMap();
			CreateMap<Common.ManagerSettingsResponse, Core.ManagerSettings>().ReverseMap();
		}
	}
}