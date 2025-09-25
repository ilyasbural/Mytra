namespace Mytra.Service
{
	public class CollegeMapper : AutoMapper.Profile
	{
		public CollegeMapper()
		{
			CreateMap<Utilize.CollegeInsert, Core.College>().ReverseMap();
			CreateMap<Utilize.CollegeUpdate, Core.College>().ReverseMap();
			CreateMap<Utilize.CollegeSelect, Core.College>().ReverseMap();
			CreateMap<Utilize.CollegeSelectSingle, Core.College>().ReverseMap();
			CreateMap<Utilize.CollegeResponse, Core.College>().ReverseMap();
		}
	}
}