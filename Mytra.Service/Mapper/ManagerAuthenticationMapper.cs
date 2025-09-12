namespace Mytra.Service
{
	public class ManagerAuthenticationMapper : AutoMapper.Profile
	{
		public ManagerAuthenticationMapper()
		{
			CreateMap<Common.ManagerAuthenticationInsert, Core.ManagerAuthentication>().ReverseMap();
			CreateMap<Common.ManagerAuthenticationUpdate, Core.ManagerAuthentication>().ReverseMap();
			CreateMap<Common.ManagerAuthenticationSelect, Core.ManagerAuthentication>().ReverseMap();
			CreateMap<Common.ManagerAuthenticationSelectSingle, Core.ManagerAuthentication>().ReverseMap();
			CreateMap<Common.ManagerAuthenticationResponse, Core.ManagerAuthentication>().ReverseMap();
		}
	}
}