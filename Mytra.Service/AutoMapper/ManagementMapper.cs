namespace Mytra.Service
{
    public class ManagementMapper : AutoMapper.Profile
    {
        public ManagementMapper()
        {
            CreateMap<Core.ManagementInsertDataTransfer, Core.Management>();
            CreateMap<Core.ManagementUpdateDataTransfer, Core.Management>();
            CreateMap<Core.ManagementDeleteDataTransfer, Core.Management>();
            CreateMap<Core.ManagementSelectDataTransfer, Core.Management>();
            CreateMap<Core.ManagementAnyDataTransfer, Core.Management>();
        }
    }
}