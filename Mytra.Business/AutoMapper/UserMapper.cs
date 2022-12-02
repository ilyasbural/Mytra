namespace Mytra.Business
{
    public class UserMapper : AutoMapper.Profile
    {
        public UserMapper()
        {
            CreateMap<Core.UserInsertDataTransfer, Core.User>();
            CreateMap<Core.UserUpdateDataTransfer, Core.User>();
        }
    }
}