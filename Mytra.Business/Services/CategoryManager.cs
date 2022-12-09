namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public partial class CategoryManager : BusinessObject<Category>, ICategoryService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Category> Validator;

        public CategoryManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Category> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<CategoryResponse> InsertAsync(CategoryInsertDataTransfer Model)
        {
            Category category = Mapper.Map<Category>(Model);
            category.Id = Guid.NewGuid();
            category.RegisterDate = DateTime.Now;
            category.UpdateDate = DateTime.Now;
            category.IsActive = true;

            await UnitOfWork.Category.InsertAsync(category);
            await UnitOfWork.SaveChangesAsync();

            return new CategoryResponse { Category = category };
        }

        public async Task<CategoryResponse> UpdateAsync(CategoryUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryResponse> DeleteAsync(CategoryDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryResponse> SelectAsync(CategorySelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryResponse> AnyAsync(CategoryAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}