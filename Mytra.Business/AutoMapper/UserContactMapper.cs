namespace Mytra.Business
{
    public class UserContactMapper : AutoMapper.Profile
    {
        public UserContactMapper()
        {
            CreateMap<Core.UserContactInsertDataTransfer, Core.UserContact>();
            CreateMap<Core.UserContactUpdateDataTransfer, Core.UserContact>();
        }
    }
}