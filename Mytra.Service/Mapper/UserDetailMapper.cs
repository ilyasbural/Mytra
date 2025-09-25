namespace Mytra.Service
{
	public class UserDetailMapper : AutoMapper.Profile
	{
		public UserDetailMapper()
		{
			CreateMap<Utilize.UserDetailInsert, Core.UserDetail>().ReverseMap();
			CreateMap<Utilize.UserDetailUpdate, Core.UserDetail>().ReverseMap();
			CreateMap<Utilize.UserDetailSelect, Core.UserDetail>().ReverseMap();
			CreateMap<Utilize.UserDetailSelectSingle, Core.UserDetail>().ReverseMap();
			CreateMap<Utilize.UserDetailResponse, Core.UserDetail>().ReverseMap();
		}
	}
}