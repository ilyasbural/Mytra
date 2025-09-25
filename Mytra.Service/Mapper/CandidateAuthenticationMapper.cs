namespace Mytra.Service
{
	public class CandidateAuthenticationMapper : AutoMapper.Profile
	{
		public CandidateAuthenticationMapper()
		{
			CreateMap<Common.CandidateAuthenticationInsert, Core.CandidateAuthentication>().ReverseMap();
			CreateMap<Common.CandidateAuthenticationUpdate, Core.CandidateAuthentication>().ReverseMap();
			CreateMap<Common.CandidateAuthenticationSelect, Core.CandidateAuthentication>().ReverseMap();
			CreateMap<Common.CandidateAuthenticationSelectSingle, Core.CandidateAuthentication>().ReverseMap();
			CreateMap<Common.CandidateAuthenticationResponse, Core.CandidateAuthentication>().ReverseMap();
		}
	}
}