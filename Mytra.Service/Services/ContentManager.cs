namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public partial class ContentManager : ServiceObject<Content>, IContentService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Content> Validator;

        public ContentManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Content> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Content>> InsertAsync(ContentInsertDataTransfer Model)
        {
            Entity = Mapper.Map<Content>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Content.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Content>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Content>> UpdateAsync(ContentUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.Content.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Content>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Content.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Content>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Content>> DeleteAsync(ContentDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.Content.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Content>(Collection[0]);

            await UnitOfWork.Content.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Content>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Content>> SelectAsync(ContentSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.Content.SelectAsync(x => x.IsActive == true);
            return new Response<Content>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Content>> AnySelectAsync(ContentAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.Content.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Content>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}