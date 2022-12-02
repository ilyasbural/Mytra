namespace Mytra.Business
{
    public class PermissionMapper : AutoMapper.Profile
    {
        public PermissionMapper()
        {
            CreateMap<Core.PermissionInsertDataTransfer, Core.Permission>();
            CreateMap<Core.PermissionUpdateDataTransfer, Core.Permission>();
        }
    }
}