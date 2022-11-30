namespace Mytra.Business
{
    public class AnnounceMapper : AutoMapper.Profile
    {
        public AnnounceMapper()
        {
            CreateMap<Core.AnnounceInsertDataTransfer, Core.Announce>();
            //CreateMap<Core.AnnounceDataTransferInsert, Core.Announce>();
            //CreateMap<Core.AnnounceDataTransferUpdate, Core.Announce>();
            //CreateMap<Core.AnnounceDataTransferDelete, Core.Announce>();
            //CreateMap<Core.Announce, Core.AnnounceInsertDataTransfer>();
            //CreateMap<Core.Announce, Core.AnnounceDataTransferInsert>();
            //CreateMap<Core.Announce, Core.AnnounceDataTransferUpdate>();
            //CreateMap<Core.Announce, Core.AnnounceDataTransferDelete>();
        }
    }
}