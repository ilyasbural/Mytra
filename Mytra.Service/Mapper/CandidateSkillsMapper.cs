namespace Mytra.Service
{
	public class CandidateSkillsMapper : AutoMapper.Profile
	{
		public CandidateSkillsMapper()
		{
			CreateMap<Common.CandidateSkillsInsert, Core.CandidateSkills>().ReverseMap();
			CreateMap<Common.CandidateSkillsUpdate, Core.CandidateSkills>().ReverseMap();
			CreateMap<Common.CandidateSkillsDelete, Core.CandidateSkills>().ReverseMap();
			CreateMap<Common.CandidateSkillsSelect, Core.CandidateSkills>().ReverseMap();
			CreateMap<Common.CandidateSkillsSelectSingle, Core.CandidateSkills>().ReverseMap();
		}
	}
}