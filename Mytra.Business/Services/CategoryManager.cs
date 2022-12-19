namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

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
            Entity = Mapper.Map<Category>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.Category.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new CategoryResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<CategoryResponse> UpdateAsync(CategoryUpdateDataTransfer Model)
        {
            List<Category> categoryDataSource = await UnitOfWork.Category.SelectAsync(x => x.Id == Model.Id);
            Category category = Mapper.Map<Category>(categoryDataSource[0]);
            category.UpdateDate = DateTime.Now;







            await UnitOfWork.Category.UpdateAsync(category);
            int result = await UnitOfWork.SaveChangesAsync();

            return new CategoryResponse 
            {
                Single = category,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<CategoryResponse> DeleteAsync(CategoryDeleteDataTransfer Model)
        {
            List<Category> categoryDataSource = await UnitOfWork.Category.SelectAsync(x => x.Id == Model.Id);
            Category category = Mapper.Map<Category>(categoryDataSource[0]);









            await UnitOfWork.Category.DeleteAsync(category);
            int result = await UnitOfWork.SaveChangesAsync();

            return new CategoryResponse
            {
                Single = category,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<CategoryResponse> SelectAsync(CategorySelectDataTransfer Model)
        {
            List<Category> categoryDataSource = await UnitOfWork.Category.SelectAsync(x => x.IsActive == true);
            return new CategoryResponse
            {
                List = categoryDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<CategoryResponse> AnyAsync(CategoryAnyDataTransfer Model)
        {
            List<Category> categoryDataSource = await UnitOfWork.Category.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new CategoryResponse
            {
                List = categoryDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}