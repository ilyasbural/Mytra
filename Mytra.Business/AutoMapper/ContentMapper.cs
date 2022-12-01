namespace Mytra.Business
{
    public class ContentMapper : AutoMapper.Profile
    {
        public ContentMapper()
        {
            CreateMap<Core.ContentInsertDataTransfer, Core.Content>();
        }
    }
}