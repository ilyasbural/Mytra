namespace Mytra.Service
{
	public class ManagerDetailMapper : AutoMapper.Profile
	{
		public ManagerDetailMapper()
		{
			CreateMap<Utilize.ManagerDetailInsert, Core.ManagerDetail>().ReverseMap();
			CreateMap<Utilize.ManagerDetailUpdate, Core.ManagerDetail>().ReverseMap();
			CreateMap<Utilize.ManagerDetailSelect, Core.ManagerDetail>().ReverseMap();
			CreateMap<Utilize.ManagerDetailSelectSingle, Core.ManagerDetail>().ReverseMap();
			CreateMap<Utilize.ManagerDetailResponse, Core.ManagerDetail>().ReverseMap();
		}
	}
}