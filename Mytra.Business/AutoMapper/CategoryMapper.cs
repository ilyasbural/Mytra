namespace Mytra.Business
{
    public class CategoryMapper : AutoMapper.Profile
    {
        public CategoryMapper()
        {
            CreateMap<Core.CategoryInsertDataTransfer, Core.Category>();
        }
    }
}