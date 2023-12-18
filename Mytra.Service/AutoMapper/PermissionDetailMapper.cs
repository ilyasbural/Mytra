namespace Mytra.Service
{
    public class PermissionDetailMapper : AutoMapper.Profile
    {
        public PermissionDetailMapper()
        {
            CreateMap<Core.PermissionDetailInsertDataTransfer, Core.PermissionDetail>();
            CreateMap<Core.PermissionDetailUpdateDataTransfer, Core.PermissionDetail>();
            CreateMap<Core.PermissionDetailDeleteDataTransfer, Core.PermissionDetail>();
            CreateMap<Core.PermissionDetailSelectDataTransfer, Core.PermissionDetail>();
            CreateMap<Core.PermissionDetailUpdateDataTransfer, Core.PermissionDetail>();
        }
    }
}