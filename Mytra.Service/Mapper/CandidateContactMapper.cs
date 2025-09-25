namespace Mytra.Service
{
	public class CandidateContactMapper : AutoMapper.Profile
	{
		public CandidateContactMapper()
		{
			CreateMap<Utilize.CandidateContactInsert, Core.CandidateContact>().ReverseMap();
			CreateMap<Utilize.CandidateContactUpdate, Core.CandidateContact>().ReverseMap();
			CreateMap<Utilize.CandidateContactSelect, Core.CandidateContact>().ReverseMap();
			CreateMap<Utilize.CandidateContactSelectSingle, Core.CandidateContact>().ReverseMap();
			CreateMap<Utilize.CandidateContactResponse, Core.CandidateContact>().ReverseMap();
		}
	}
}