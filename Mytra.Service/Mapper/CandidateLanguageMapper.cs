namespace Mytra.Service
{
	public class CandidateLanguageMapper : AutoMapper.Profile
	{
		public CandidateLanguageMapper()
		{
			CreateMap<Common.CandidateLanguageInsert, Core.CandidateLanguage>().ReverseMap();
			CreateMap<Common.CandidateLanguageUpdate, Core.CandidateLanguage>().ReverseMap();
			CreateMap<Common.CandidateLanguageSelect, Core.CandidateLanguage>().ReverseMap();
			CreateMap<Common.CandidateLanguageSelectSingle, Core.CandidateLanguage>().ReverseMap();
			CreateMap<Common.CandidateLanguageResponse, Core.CandidateLanguage>().ReverseMap();
		}
	}
}