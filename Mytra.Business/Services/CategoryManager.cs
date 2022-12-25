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

        public async Task<Response<Category>> InsertAsync(CategoryInsertDataTransfer Model)
        {
            Entity = Mapper.Map<Category>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);
            await UnitOfWork.Category.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Category>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Category>> UpdateAsync(CategoryUpdateDataTransfer Model)
        {
            List<Category> categoryDataSource = await UnitOfWork.Category.SelectAsync(x => x.Id == Model.Id);
            Category category = Mapper.Map<Category>(categoryDataSource[0]);
            category.UpdateDate = DateTime.Now;







            await UnitOfWork.Category.UpdateAsync(category);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Category>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Category>> DeleteAsync(CategoryDeleteDataTransfer Model)
        {
            List<Category> categoryDataSource = await UnitOfWork.Category.SelectAsync(x => x.Id == Model.Id);
            Category category = Mapper.Map<Category>(categoryDataSource[0]);









            await UnitOfWork.Category.DeleteAsync(category);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Category>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Category>> SelectAsync(CategorySelectDataTransfer Model)
        {
            List<Category> categoryDataSource = await UnitOfWork.Category.SelectAsync(x => x.IsActive == true);
            return new Response<Category>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Category>> AnySelectAsync(CategoryAnyDataTransfer Model)
        {
            List<Category> categoryDataSource = await UnitOfWork.Category.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Category>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }
    }
}