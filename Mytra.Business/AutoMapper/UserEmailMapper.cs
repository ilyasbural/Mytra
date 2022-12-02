namespace Mytra.Business
{
    public class UserEmailMapper : AutoMapper.Profile
    {
        public UserEmailMapper()
        {
            CreateMap<Core.UserEmailInsertDataTransfer, Core.UserEmail>();
            CreateMap<Core.UserEmailUpdateDataTransfer, Core.UserEmail>();
            CreateMap<Core.UserEmailDeleteDataTransfer, Core.UserEmail>();
            CreateMap<Core.UserEmailSelectDataTransfer, Core.UserEmail>();
            CreateMap<Core.UserEmailAnyDataTransfer, Core.UserEmail>();
        }
    }
}