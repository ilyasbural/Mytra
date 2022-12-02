namespace Mytra.Business
{
    public class AnnounceDetailMapper : AutoMapper.Profile
    {
        public AnnounceDetailMapper()
        {
            CreateMap<Core.AnnounceDetailInsertDataTransfer, Core.AnnounceDetail>();
            CreateMap<Core.AnnounceDetailUpdateDataTransfer, Core.AnnounceDetail>();
            CreateMap<Core.AnnounceDetailDeleteDataTransfer, Core.AnnounceDetail>();
            CreateMap<Core.AnnounceDetailSelectDataTransfer, Core.AnnounceDetail>();
            CreateMap<Core.AnnounceDetailAnyDataTransfer, Core.AnnounceDetail>();
        }
    }
}