namespace Mytra.Service
{
    public class ManagementDetailMapper : AutoMapper.Profile
    {
        public ManagementDetailMapper()
        {
            CreateMap<Core.ManagementDetailInsertDataTransfer, Core.ManagementDetail>();
            CreateMap<Core.ManagementDetailUpdateDataTransfer, Core.ManagementDetail>();
            CreateMap<Core.ManagementDetailDeleteDataTransfer, Core.ManagementDetail>();
            CreateMap<Core.ManagementDetailSelectDataTransfer, Core.ManagementDetail>();
            CreateMap<Core.ManagementDetailAnyDataTransfer, Core.ManagementDetail>();
        }
    }
}