namespace Mytra.Service
{
	public class InstitutionMapper : AutoMapper.Profile
	{
		public InstitutionMapper()
		{
			CreateMap<Common.InstitutionInsert, Core.Institution>().ReverseMap();
			CreateMap<Common.InstitutionUpdate, Core.Institution>().ReverseMap();
			CreateMap<Common.InstitutionSelect, Core.Institution>().ReverseMap();
			CreateMap<Common.InstitutionSelectSingle, Core.Institution>().ReverseMap();
			CreateMap<Common.InstitutionResponse, Core.Institution>().ReverseMap();
		}
	}
}