namespace Mytra.Service
{
	public class InstitutionMapper : AutoMapper.Profile
	{
		public InstitutionMapper()
		{
			CreateMap<Utilize.InstitutionInsert, Core.Institution>().ReverseMap();
			CreateMap<Utilize.InstitutionUpdate, Core.Institution>().ReverseMap();
			CreateMap<Utilize.InstitutionSelect, Core.Institution>().ReverseMap();
			CreateMap<Utilize.InstitutionSelectSingle, Core.Institution>().ReverseMap();
			CreateMap<Utilize.InstitutionResponse, Core.Institution>().ReverseMap();
		}
	}
}