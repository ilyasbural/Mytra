namespace Mytra.Business
{
    public class AnnounceDetailMapper : AutoMapper.Profile
    {
        public AnnounceDetailMapper()
        {
            CreateMap<Core.AnnounceDetailInsertDataTransfer, Core.AnnounceDetail>();
        }
    }
}