namespace Mytra.Service
{
	public class ManagerDetailMapper : AutoMapper.Profile
	{
		public ManagerDetailMapper()
		{
			CreateMap<Common.ManagerDetailInsert, Core.ManagerDetail>().ReverseMap();
			CreateMap<Common.ManagerDetailUpdate, Core.ManagerDetail>().ReverseMap();
			CreateMap<Common.ManagerDetailDelete, Core.ManagerDetail>().ReverseMap();
			CreateMap<Common.ManagerDetailSelect, Core.ManagerDetail>().ReverseMap();
			CreateMap<Common.ManagerDetailSelectSingle, Core.ManagerDetail>().ReverseMap();
		}
	}
}