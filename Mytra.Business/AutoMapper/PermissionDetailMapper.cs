namespace Mytra.Business
{
    public class PermissionDetailMapper : AutoMapper.Profile
    {
        public PermissionDetailMapper()
        {
            CreateMap<Core.PermissionDetailInsertDataTransfer, Core.PermissionDetail>();
        }
    }
}