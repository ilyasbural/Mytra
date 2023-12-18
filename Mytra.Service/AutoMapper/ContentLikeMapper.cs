namespace Mytra.Service
{
    public class ContentLikeMapper : AutoMapper.Profile
    {
        public ContentLikeMapper()
        {
            CreateMap<Core.ContentLikeInsertDataTransfer, Core.ContentLike>();
            CreateMap<Core.ContentLikeUpdateDataTransfer, Core.ContentLike>();
            CreateMap<Core.ContentLikeDeleteDataTransfer, Core.ContentLike>();
            CreateMap<Core.ContentLikeSelectDataTransfer, Core.ContentLike>();
            CreateMap<Core.ContentLikeAnyDataTransfer, Core.ContentLike>();
        }
    }
}