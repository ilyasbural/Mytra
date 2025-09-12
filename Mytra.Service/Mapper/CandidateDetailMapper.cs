namespace Mytra.Service
{
	public class CandidateDetailMapper : AutoMapper.Profile
	{
		public CandidateDetailMapper()
		{
			CreateMap<Common.CandidateDetailInsert, Core.CandidateDetail>().ReverseMap();
			CreateMap<Common.CandidateDetailUpdate, Core.CandidateDetail>().ReverseMap();
			CreateMap<Common.CandidateDetailSelect, Core.CandidateDetail>().ReverseMap();
			CreateMap<Common.CandidateDetailSelectSingle, Core.CandidateDetail>().ReverseMap();
			CreateMap<Common.CandidateDetailResponse, Core.CandidateDetail>().ReverseMap();
		}
	}
}