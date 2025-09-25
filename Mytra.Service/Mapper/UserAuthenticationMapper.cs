namespace Mytra.Service
{
	public class UserAuthenticationMapper : AutoMapper.Profile
	{
		public UserAuthenticationMapper()
		{
			CreateMap<Utilize.UserAuthenticationInsert, Core.UserAuthentication>().ReverseMap();
			CreateMap<Utilize.UserAuthenticationUpdate, Core.UserAuthentication>().ReverseMap();
			CreateMap<Utilize.UserAuthenticationSelect, Core.UserAuthentication>().ReverseMap();
			CreateMap<Utilize.UserAuthenticationSelectSingle, Core.UserAuthentication>().ReverseMap();
			CreateMap<Utilize.UserAuthenticationResponse, Core.UserAuthentication>().ReverseMap();
		}
	}
}