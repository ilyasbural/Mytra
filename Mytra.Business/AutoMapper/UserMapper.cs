namespace Mytra.Business
{
    public class UserMapper : AutoMapper.Profile
    {
        public UserMapper()
        {
            CreateMap<Core.UserInsertDataTransfer, Core.User>();
            CreateMap<Core.UserUpdateDataTransfer, Core.User>();
            CreateMap<Core.UserDeleteDataTransfer, Core.User>();
            CreateMap<Core.UserSelectDataTransfer, Core.User>();
            CreateMap<Core.UserAnyDataTransfer, Core.User>();
        }
    }
}