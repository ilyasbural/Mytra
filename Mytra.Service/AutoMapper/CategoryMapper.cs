namespace Mytra.Service
{
    public class CategoryMapper : AutoMapper.Profile
    {
        public CategoryMapper()
        {
            CreateMap<Core.CategoryInsertDataTransfer, Core.Category>();
            CreateMap<Core.CategoryUpdateDataTransfer, Core.Category>();
            CreateMap<Core.CategoryDeleteDataTransfer, Core.Category>();
            CreateMap<Core.CategorySelectDataTransfer, Core.Category>();
            CreateMap<Core.CategoryAnyDataTransfer, Core.Category>();
        }
    }
}