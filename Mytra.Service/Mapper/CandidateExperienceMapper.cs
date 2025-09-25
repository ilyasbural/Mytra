namespace Mytra.Service
{
	public class CandidateExperienceMapper : AutoMapper.Profile
	{
		public CandidateExperienceMapper()
		{
			CreateMap<Common.CandidateExperienceInsert, Core.CandidateExperience>().ReverseMap();
			CreateMap<Common.CandidateExperienceUpdate, Core.CandidateExperience>().ReverseMap();
			CreateMap<Common.CandidateExperienceSelect, Core.CandidateExperience>().ReverseMap();
			CreateMap<Common.CandidateExperienceSelectSingle, Core.CandidateExperience>().ReverseMap();
			CreateMap<Common.CandidateExperienceResponse, Core.CandidateExperience>().ReverseMap();
		}
	}
}