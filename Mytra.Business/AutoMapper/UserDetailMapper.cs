namespace Mytra.Business
{
    public class UserDetailMapper : AutoMapper.Profile
    {
        public UserDetailMapper()
        {
            CreateMap<Core.UserDetailInsertDataTransfer, Core.UserDetail>();
        }
    }
}