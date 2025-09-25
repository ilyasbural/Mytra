namespace Mytra.Service
{
	public class SkillsMapper : AutoMapper.Profile
	{
		public SkillsMapper()
		{
			CreateMap<Utilize.SkillsInsert, Core.Skills>().ReverseMap();
			CreateMap<Utilize.SkillsUpdate, Core.Skills>().ReverseMap();
			CreateMap<Utilize.SkillsSelect, Core.Skills>().ReverseMap();
			CreateMap<Utilize.SkillsSelectSingle, Core.Skills>().ReverseMap();
			CreateMap<Utilize.SkillsResponse, Core.Skills>().ReverseMap();
		}
	}
}