namespace Mytra.Service
{
	public class CandidateExperienceMapper : AutoMapper.Profile
	{
		public CandidateExperienceMapper()
		{
			CreateMap<Utilize.CandidateExperienceInsert, Core.CandidateExperience>().ReverseMap();
			CreateMap<Utilize.CandidateExperienceUpdate, Core.CandidateExperience>().ReverseMap();
			CreateMap<Utilize.CandidateExperienceSelect, Core.CandidateExperience>().ReverseMap();
			CreateMap<Utilize.CandidateExperienceSelectSingle, Core.CandidateExperience>().ReverseMap();
			CreateMap<Utilize.CandidateExperienceResponse, Core.CandidateExperience>().ReverseMap();
		}
	}
}