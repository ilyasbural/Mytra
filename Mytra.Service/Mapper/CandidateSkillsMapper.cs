namespace Mytra.Service
{
	public class CandidateSkillsMapper : AutoMapper.Profile
	{
		public CandidateSkillsMapper()
		{
			CreateMap<Utilize.CandidateSkillsInsert, Core.CandidateSkills>().ReverseMap();
			CreateMap<Utilize.CandidateSkillsUpdate, Core.CandidateSkills>().ReverseMap();
			CreateMap<Utilize.CandidateSkillsSelect, Core.CandidateSkills>().ReverseMap();
			CreateMap<Utilize.CandidateSkillsSelectSingle, Core.CandidateSkills>().ReverseMap();
			CreateMap<Utilize.CandidateSkillsResponse, Core.CandidateSkills>().ReverseMap();
		}
	}
}