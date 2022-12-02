namespace Mytra.Business
{
    public class ManagementDetailMapper : AutoMapper.Profile
    {
        public ManagementDetailMapper()
        {
            CreateMap<Core.ManagementDetailInsertDataTransfer, Core.ManagementDetail>();
            CreateMap<Core.ManagementDetailUpdateDataTransfer, Core.ManagementDetail>();
        }
    }
}