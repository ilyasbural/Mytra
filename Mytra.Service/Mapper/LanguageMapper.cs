namespace Mytra.Service
{
	public class LanguageMapper : AutoMapper.Profile
	{
		public LanguageMapper()
		{
			CreateMap<Utilize.LanguageInsert, Core.Language>().ReverseMap();
			CreateMap<Utilize.LanguageUpdate, Core.Language>().ReverseMap();
			CreateMap<Utilize.LanguageSelect, Core.Language>().ReverseMap();
			CreateMap<Utilize.LanguageSelectSingle, Core.Language>().ReverseMap();
			CreateMap<Utilize.LanguageResponse, Core.Language>().ReverseMap();
		}
	}
}