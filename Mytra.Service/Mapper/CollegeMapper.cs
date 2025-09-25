namespace Mytra.Service
{
	public class CollegeMapper : AutoMapper.Profile
	{
		public CollegeMapper()
		{
			CreateMap<Common.CollegeInsert, Core.College>().ReverseMap();
			CreateMap<Common.CollegeUpdate, Core.College>().ReverseMap();
			CreateMap<Common.CollegeSelect, Core.College>().ReverseMap();
			CreateMap<Common.CollegeSelectSingle, Core.College>().ReverseMap();
			CreateMap<Common.CollegeResponse, Core.College>().ReverseMap();
		}
	}
}