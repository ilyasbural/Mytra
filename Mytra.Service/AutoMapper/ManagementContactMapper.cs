namespace Mytra.Service
{
    public class ManagementContactMapper : AutoMapper.Profile
    {
        public ManagementContactMapper()
        {
            CreateMap<Core.ManagementContactInsertDataTransfer, Core.ManagementContact>();
            CreateMap<Core.ManagementContactUpdateDataTransfer, Core.ManagementContact>();
            CreateMap<Core.ManagementContactDeleteDataTransfer, Core.ManagementContact>();
            CreateMap<Core.ManagementContactSelectDataTransfer, Core.ManagementContact>();
            CreateMap<Core.ManagementContactAnyDataTransfer, Core.ManagementContact>();
        }
    }
}