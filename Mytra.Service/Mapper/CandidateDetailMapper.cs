namespace Mytra.Service
{
	public class CandidateDetailMapper : AutoMapper.Profile
	{
		public CandidateDetailMapper()
		{
			CreateMap<Utilize.CandidateDetailInsert, Core.CandidateDetail>().ReverseMap();
			CreateMap<Utilize.CandidateDetailUpdate, Core.CandidateDetail>().ReverseMap();
			CreateMap<Utilize.CandidateDetailSelect, Core.CandidateDetail>().ReverseMap();
			CreateMap<Utilize.CandidateDetailSelectSingle, Core.CandidateDetail>().ReverseMap();
			CreateMap<Utilize.CandidateDetailResponse, Core.CandidateDetail>().ReverseMap();
		}
	}
}