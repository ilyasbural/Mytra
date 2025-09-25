namespace Mytra.Service
{
	public class ManagerMapper : AutoMapper.Profile
	{
		public ManagerMapper()
		{
			CreateMap<Utilize.ManagerInsert, Core.Manager>().ReverseMap();
			CreateMap<Utilize.ManagerUpdate, Core.Manager>().ReverseMap();
			CreateMap<Utilize.ManagerSelect, Core.Manager>().ReverseMap();
			CreateMap<Utilize.ManagerSelectSingle, Core.Manager>().ReverseMap();
			CreateMap<Utilize.ManagerResponse, Core.Manager>().ReverseMap();
		}
	}
}