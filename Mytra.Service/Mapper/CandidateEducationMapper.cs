namespace Mytra.Service
{
	public class CandidateEducationMapper : AutoMapper.Profile
	{
		public CandidateEducationMapper()
		{
			CreateMap<Utilize.CandidateEducationInsert, Core.CandidateEducation>().ReverseMap();
			CreateMap<Utilize.CandidateEducationUpdate, Core.CandidateEducation>().ReverseMap();
			CreateMap<Utilize.CandidateEducationSelect, Core.CandidateEducation>().ReverseMap();
			CreateMap<Utilize.CandidateEducationSelectSingle, Core.CandidateEducation>().ReverseMap();
			CreateMap<Utilize.CandidateEducationResponse, Core.CandidateEducation>().ReverseMap();
		}
	}
}