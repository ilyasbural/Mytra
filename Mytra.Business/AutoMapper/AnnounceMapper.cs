namespace Mytra.Business
{
    public class AnnounceMapper : AutoMapper.Profile
    {
        public AnnounceMapper()
        {
            CreateMap<Core.AnnounceInsertDataTransfer, Core.Announce>();
            CreateMap<Core.AnnounceUpdateDataTransfer, Core.Announce>();
            CreateMap<Core.AnnounceDeleteDataTransfer, Core.Announce>();
            CreateMap<Core.AnnounceSelectDataTransfer, Core.Announce>();
            CreateMap<Core.AnnounceAnyDataTransfer, Core.Announce>();
        }
    }
}