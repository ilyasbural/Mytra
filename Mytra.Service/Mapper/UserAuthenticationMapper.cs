namespace Mytra.Service
{
	public class UserAuthenticationMapper : AutoMapper.Profile
	{
		public UserAuthenticationMapper()
		{
			CreateMap<Common.UserAuthenticationInsert, Core.UserAuthentication>().ReverseMap();
			CreateMap<Common.UserAuthenticationUpdate, Core.UserAuthentication>().ReverseMap();
			CreateMap<Common.UserAuthenticationSelect, Core.UserAuthentication>().ReverseMap();
			CreateMap<Common.UserAuthenticationSelectSingle, Core.UserAuthentication>().ReverseMap();
			CreateMap<Common.UserAuthenticationResponse, Core.UserAuthentication>().ReverseMap();
		}
	}
}