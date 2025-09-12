namespace Mytra.Service
{
	public class LanguageMapper : AutoMapper.Profile
	{
		public LanguageMapper()
		{
			CreateMap<Common.LanguageInsert, Core.Language>().ReverseMap();
			CreateMap<Common.LanguageUpdate, Core.Language>().ReverseMap();
			CreateMap<Common.LanguageSelect, Core.Language>().ReverseMap();
			CreateMap<Common.LanguageSelectSingle, Core.Language>().ReverseMap();
			CreateMap<Common.LanguageResponse, Core.Language>().ReverseMap();
		}
	}
}