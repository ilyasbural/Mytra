namespace Mytra.Service
{
	public class CandidateSettingsMapper : AutoMapper.Profile
	{
		public CandidateSettingsMapper()
		{
			CreateMap<Common.CandidateSettingsInsert, Core.CandidateSettings>().ReverseMap();
			CreateMap<Common.CandidateSettingsUpdate, Core.CandidateSettings>().ReverseMap();
			CreateMap<Common.CandidateSettingsSelect, Core.CandidateSettings>().ReverseMap();
			CreateMap<Common.CandidateSettingsSelectSingle, Core.CandidateSettings>().ReverseMap();
			CreateMap<Common.CandidateSettingsResponse, Core.CandidateSettings>().ReverseMap();
		}
	}
}