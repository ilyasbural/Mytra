namespace Mytra.Business
{
    public class ContentCommentMapper : AutoMapper.Profile
    {
        public ContentCommentMapper()
        {
            CreateMap<Core.ContentCommentInsertDataTransfer, Core.ContentComment>();
            CreateMap<Core.ContentCommentUpdateDataTransfer, Core.ContentComment>();
        }
    }
}