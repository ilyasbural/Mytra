namespace Mytra.Service
{
	public class UserMapper : AutoMapper.Profile
	{
		public UserMapper()
		{
			CreateMap<Utilize.UserInsert, Core.User>().ReverseMap();
			CreateMap<Utilize.UserUpdate, Core.User>().ReverseMap();
			CreateMap<Utilize.UserSelect, Core.User>().ReverseMap();
			CreateMap<Utilize.UserSelectSingle, Core.User>().ReverseMap();
			CreateMap<Utilize.UserResponse, Core.User>().ReverseMap();
		}
	}
}