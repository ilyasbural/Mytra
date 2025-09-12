namespace Mytra.Service
{
	public class CandidateReferanceMapper : AutoMapper.Profile
	{
		public CandidateReferanceMapper()
		{
			CreateMap<Common.CandidateReferanceInsert, Core.CandidateReferance>().ReverseMap();
			CreateMap<Common.CandidateReferanceUpdate, Core.CandidateReferance>().ReverseMap();
			CreateMap<Common.CandidateReferanceSelect, Core.CandidateReferance>().ReverseMap();
			CreateMap<Common.CandidateReferanceSelectSingle, Core.CandidateReferance>().ReverseMap();
			CreateMap<Common.CandidateReferanceResponse, Core.CandidateReferance>().ReverseMap();
		}
	}
}