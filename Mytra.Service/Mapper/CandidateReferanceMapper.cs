namespace Mytra.Service
{
	public class CandidateReferanceMapper : AutoMapper.Profile
	{
		public CandidateReferanceMapper()
		{
			CreateMap<Utilize.CandidateReferanceInsert, Core.CandidateReferance>().ReverseMap();
			CreateMap<Utilize.CandidateReferanceUpdate, Core.CandidateReferance>().ReverseMap();
			CreateMap<Utilize.CandidateReferanceSelect, Core.CandidateReferance>().ReverseMap();
			CreateMap<Utilize.CandidateReferanceSelectSingle, Core.CandidateReferance>().ReverseMap();
			CreateMap<Utilize.CandidateReferanceResponse, Core.CandidateReferance>().ReverseMap();
		}
	}
}