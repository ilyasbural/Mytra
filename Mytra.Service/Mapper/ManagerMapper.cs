namespace Mytra.Service
{
	public class ManagerMapper : AutoMapper.Profile
	{
		public ManagerMapper()
		{
			CreateMap<Common.ManagerInsert, Core.Manager>().ReverseMap();
			CreateMap<Common.ManagerUpdate, Core.Manager>().ReverseMap();
			CreateMap<Common.ManagerDelete, Core.Manager>().ReverseMap();
			CreateMap<Common.ManagerSelect, Core.Manager>().ReverseMap();
			CreateMap<Common.ManagerSelectSingle, Core.Manager>().ReverseMap();
			CreateMap<Common.ManagerResponse, Core.Manager>().ReverseMap();
		}
	}
}