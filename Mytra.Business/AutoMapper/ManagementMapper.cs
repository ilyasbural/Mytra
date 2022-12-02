namespace Mytra.Business
{
    public class ManagementMapper : AutoMapper.Profile
    {
        public ManagementMapper()
        {
            CreateMap<Core.ManagementInsertDataTransfer, Core.Management>();
            CreateMap<Core.ManagementUpdateDataTransfer, Core.Management>();
        }
    }
}