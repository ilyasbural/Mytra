namespace Mytra.Service
{
    public class PermissionMapper : AutoMapper.Profile
    {
        public PermissionMapper()
        {
            CreateMap<Core.PermissionInsertDataTransfer, Core.Permission>();
            CreateMap<Core.PermissionUpdateDataTransfer, Core.Permission>();
            CreateMap<Core.PermissionDeleteDataTransfer, Core.Permission>();
            CreateMap<Core.PermissionSelectDataTransfer, Core.Permission>();
            CreateMap<Core.PermissionUpdateDataTransfer, Core.Permission>();
        }
    }
}