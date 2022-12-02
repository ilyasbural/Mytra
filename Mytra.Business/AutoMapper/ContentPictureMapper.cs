namespace Mytra.Business
{
    public class ContentPictureMapper : AutoMapper.Profile 
    {
        public ContentPictureMapper()
        {
            CreateMap<Core.ContentPictureInsertDataTransfer, Core.ContentPicture>();
            CreateMap<Core.ContentPictureUpdateDataTransfer, Core.ContentPicture>();
            CreateMap<Core.ContentPictureDeleteDataTransfer, Core.ContentPicture>();
            CreateMap<Core.ContentPictureSelectDataTransfer, Core.ContentPicture>();
            CreateMap<Core.ContentPictureAnyDataTransfer, Core.ContentPicture>();
        }
    }
}