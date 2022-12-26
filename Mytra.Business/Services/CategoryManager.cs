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
            Collection = await UnitOfWork.Category.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Category>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Category.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Category>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Category>> DeleteAsync(CategoryDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.Category.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Category>(Collection[0]);

            await UnitOfWork.Category.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Category>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Category>> SelectAsync(CategorySelectDataTransfer Model)
        {
            Collection = await UnitOfWork.Category.SelectAsync(x => x.IsActive == true);
            return new Response<Category>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Category>> AnySelectAsync(CategoryAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.Category.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Category>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}