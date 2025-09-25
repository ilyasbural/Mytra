namespace Mytra.Service
{
	public class CandidateAuthenticationMapper : AutoMapper.Profile
	{
		public CandidateAuthenticationMapper()
		{
			CreateMap<Utilize.CandidateAuthenticationInsert, Core.CandidateAuthentication>().ReverseMap();
			CreateMap<Utilize.CandidateAuthenticationUpdate, Core.CandidateAuthentication>().ReverseMap();
			CreateMap<Utilize.CandidateAuthenticationSelect, Core.CandidateAuthentication>().ReverseMap();
			CreateMap<Utilize.CandidateAuthenticationSelectSingle, Core.CandidateAuthentication>().ReverseMap();
			CreateMap<Utilize.CandidateAuthenticationResponse, Core.CandidateAuthentication>().ReverseMap();
		}
	}
}