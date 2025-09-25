namespace Mytra.Service
{
	public class CandidateLanguageMapper : AutoMapper.Profile
	{
		public CandidateLanguageMapper()
		{
			CreateMap<Utilize.CandidateLanguageInsert, Core.CandidateLanguage>().ReverseMap();
			CreateMap<Utilize.CandidateLanguageUpdate, Core.CandidateLanguage>().ReverseMap();
			CreateMap<Utilize.CandidateLanguageSelect, Core.CandidateLanguage>().ReverseMap();
			CreateMap<Utilize.CandidateLanguageSelectSingle, Core.CandidateLanguage>().ReverseMap();
			CreateMap<Utilize.CandidateLanguageResponse, Core.CandidateLanguage>().ReverseMap();
		}
	}
}