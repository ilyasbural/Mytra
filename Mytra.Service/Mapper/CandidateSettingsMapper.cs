namespace Mytra.Service
{
	public class CandidateSettingsMapper : AutoMapper.Profile
	{
		public CandidateSettingsMapper()
		{
			CreateMap<Utilize.CandidateSettingsInsert, Core.CandidateSettings>().ReverseMap();
			CreateMap<Utilize.CandidateSettingsUpdate, Core.CandidateSettings>().ReverseMap();
			CreateMap<Utilize.CandidateSettingsSelect, Core.CandidateSettings>().ReverseMap();
			CreateMap<Utilize.CandidateSettingsSelectSingle, Core.CandidateSettings>().ReverseMap();
			CreateMap<Utilize.CandidateSettingsResponse, Core.CandidateSettings>().ReverseMap();
		}
	}
}