namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class CategoryManager : ICategoryService, IDisposable
    {
        protected IMapper Mapper;
        public CategoryManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}