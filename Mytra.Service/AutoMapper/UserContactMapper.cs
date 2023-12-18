namespace Mytra.Service
{
    public class UserContactMapper : AutoMapper.Profile
    {
        public UserContactMapper()
        {
            CreateMap<Core.UserContactInsertDataTransfer, Core.UserContact>();
            CreateMap<Core.UserContactUpdateDataTransfer, Core.UserContact>();
            CreateMap<Core.UserContactDeleteDataTransfer, Core.UserContact>();
            CreateMap<Core.UserContactSelectDataTransfer, Core.UserContact>();
            CreateMap<Core.UserContactAnyDataTransfer, Core.UserContact>();
        }
    }
}