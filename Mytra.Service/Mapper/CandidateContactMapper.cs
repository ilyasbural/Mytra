namespace Mytra.Service
{
	public class CandidateContactMapper : AutoMapper.Profile
	{
		public CandidateContactMapper()
		{
			CreateMap<Common.CandidateContactInsert, Core.CandidateContact>().ReverseMap();
			CreateMap<Common.CandidateContactUpdate, Core.CandidateContact>().ReverseMap();
			CreateMap<Common.CandidateContactSelect, Core.CandidateContact>().ReverseMap();
			CreateMap<Common.CandidateContactSelectSingle, Core.CandidateContact>().ReverseMap();
			CreateMap<Common.CandidateContactResponse, Core.CandidateContact>().ReverseMap();
		}
	}
}