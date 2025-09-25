namespace Mytra.Service
{
	public class CandidateMapper : AutoMapper.Profile
	{
		public CandidateMapper()
		{
			CreateMap<Utilize.CandidateInsert, Core.Candidate>().ReverseMap();
			CreateMap<Utilize.CandidateUpdate, Core.Candidate>().ReverseMap();
			CreateMap<Utilize.CandidateSelect, Core.Candidate>().ReverseMap();
			CreateMap<Utilize.CandidateSelectSingle, Core.Candidate>().ReverseMap();
			CreateMap<Utilize.CandidateResponse, Core.Candidate>().ReverseMap();
		}
	}
}