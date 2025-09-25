namespace Mytra.Service
{
	public class ManagerAuthenticationMapper : AutoMapper.Profile
	{
		public ManagerAuthenticationMapper()
		{
			CreateMap<Utilize.ManagerAuthenticationInsert, Core.ManagerAuthentication>().ReverseMap();
			CreateMap<Utilize.ManagerAuthenticationUpdate, Core.ManagerAuthentication>().ReverseMap();
			CreateMap<Utilize.ManagerAuthenticationSelect, Core.ManagerAuthentication>().ReverseMap();
			CreateMap<Utilize.ManagerAuthenticationSelectSingle, Core.ManagerAuthentication>().ReverseMap();
			CreateMap<Utilize.ManagerAuthenticationResponse, Core.ManagerAuthentication>().ReverseMap();
		}
	}
}