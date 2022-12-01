namespace Mytra.Business
{
    public class ContentLikeMapper : AutoMapper.Profile
    {
        public ContentLikeMapper()
        {
            CreateMap<Core.ContentLikeInsertDataTransfer, Core.ContentLike>();
        }
    }
}