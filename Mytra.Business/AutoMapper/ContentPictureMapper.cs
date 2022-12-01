namespace Mytra.Business
{
    public class ContentPictureMapper : AutoMapper.Profile 
    {
        public ContentPictureMapper()
        {
            CreateMap<Core.ContentPictureInsertDataTransfer, Core.ContentPicture>();
        }
    }
}