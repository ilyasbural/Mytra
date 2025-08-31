namespace Mytra.Service
{
	public class CandidateMapper : AutoMapper.Profile
	{
		public CandidateMapper()
		{
			CreateMap<Common.CandidateInsert, Core.Candidate>().ReverseMap();
			CreateMap<Common.CandidateUpdate, Core.Candidate>().ReverseMap();
			CreateMap<Common.CandidateDelete, Core.Candidate>().ReverseMap();
			CreateMap<Common.CandidateSelect, Core.Candidate>().ReverseMap();
			CreateMap<Common.CandidateSelectSingle, Core.Candidate>().ReverseMap();
		}
	}
}