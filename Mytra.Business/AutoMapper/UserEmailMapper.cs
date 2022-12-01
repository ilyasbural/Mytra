namespace Mytra.Business
{
    public class UserEmailMapper : AutoMapper.Profile
    {
        public UserEmailMapper()
        {
            CreateMap<Core.UserEmailInsertDataTransfer, Core.UserEmail>();
        }
    }
}