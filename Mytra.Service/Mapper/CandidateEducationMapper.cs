namespace Mytra.Service
{
	public class CandidateEducationMapper : AutoMapper.Profile
	{
		public CandidateEducationMapper()
		{
			CreateMap<Common.CandidateEducationInsert, Core.CandidateEducation>().ReverseMap();
			CreateMap<Common.CandidateEducationUpdate, Core.CandidateEducation>().ReverseMap();
			CreateMap<Common.CandidateEducationSelect, Core.CandidateEducation>().ReverseMap();
			CreateMap<Common.CandidateEducationSelectSingle, Core.CandidateEducation>().ReverseMap();
			CreateMap<Common.CandidateEducationResponse, Core.CandidateEducation>().ReverseMap();
		}
	}
}