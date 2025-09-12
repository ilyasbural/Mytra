namespace Mytra.Service
{
	public class UserDetailMapper : AutoMapper.Profile
	{
		public UserDetailMapper()
		{
			CreateMap<Common.UserDetailInsert, Core.UserDetail>().ReverseMap();
			CreateMap<Common.UserDetailUpdate, Core.UserDetail>().ReverseMap();
			CreateMap<Common.UserDetailSelect, Core.UserDetail>().ReverseMap();
			CreateMap<Common.UserDetailSelectSingle, Core.UserDetail>().ReverseMap();
			CreateMap<Common.UserDetailResponse, Core.UserDetail>().ReverseMap();
		}
	}
}