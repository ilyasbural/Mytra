namespace Mytra.Business
{
    public class ManagementContactMapper : AutoMapper.Profile
    {
        public ManagementContactMapper()
        {
            CreateMap<Core.ManagementContactInsertDataTransfer, Core.ManagementContact>();
            CreateMap<Core.ManagementContactUpdateDataTransfer, Core.ManagementContact>();
        }
    }
}