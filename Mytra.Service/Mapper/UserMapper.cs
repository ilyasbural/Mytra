namespace Mytra.Service
{
	public class UserMapper : AutoMapper.Profile
	{
		public UserMapper()
		{
			CreateMap<Common.UserInsert, Core.User>().ReverseMap();
			CreateMap<Common.UserUpdate, Core.User>().ReverseMap();
			CreateMap<Common.UserSelect, Core.User>().ReverseMap();
			CreateMap<Common.UserSelectSingle, Core.User>().ReverseMap();
			CreateMap<Common.UserResponse, Core.User>().ReverseMap();
		}
	}
}