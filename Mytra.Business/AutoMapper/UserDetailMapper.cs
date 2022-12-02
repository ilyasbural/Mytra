namespace Mytra.Business
{
    public class UserDetailMapper : AutoMapper.Profile
    {
        public UserDetailMapper()
        {
            CreateMap<Core.UserDetailInsertDataTransfer, Core.UserDetail>();
            CreateMap<Core.UserDetailUpdateDataTransfer, Core.UserDetail>();
            CreateMap<Core.UserDetailDeleteDataTransfer, Core.UserDetail>();
            CreateMap<Core.UserDetailSelectDataTransfer, Core.UserDetail>();
            CreateMap<Core.UserDetailAnyDataTransfer, Core.UserDetail>();
        }
    }
}