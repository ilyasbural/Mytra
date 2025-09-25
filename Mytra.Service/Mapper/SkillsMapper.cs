namespace Mytra.Service
{
	public class SkillsMapper : AutoMapper.Profile
	{
		public SkillsMapper()
		{
			CreateMap<Common.SkillsInsert, Core.Skills>().ReverseMap();
			CreateMap<Common.SkillsUpdate, Core.Skills>().ReverseMap();
			CreateMap<Common.SkillsSelect, Core.Skills>().ReverseMap();
			CreateMap<Common.SkillsSelectSingle, Core.Skills>().ReverseMap();
			CreateMap<Common.SkillsResponse, Core.Skills>().ReverseMap();
		}
	}
}