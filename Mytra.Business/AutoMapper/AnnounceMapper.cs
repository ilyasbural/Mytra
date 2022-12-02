namespace Mytra.Business
{
    public class AnnounceMapper : AutoMapper.Profile
    {
        public AnnounceMapper()
        {
            CreateMap<Core.AnnounceInsertDataTransfer, Core.Announce>();
            CreateMap<Core.AnnounceUpdateDataTransfer, Core.Announce>();
        }
    }
}