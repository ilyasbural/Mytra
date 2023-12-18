namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class ContentTypeManager : ServiceObject<ContentType>, IContentTypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentType> Validator;

        public ContentTypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentType> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ContentType>> InsertAsync(ContentTypeInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentType>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);


            await UnitOfWork.ContentType.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentType>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentType>> UpdateAsync(ContentTypeUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentType.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentType>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentType.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentType>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentType>> DeleteAsync(ContentTypeDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentType.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentType>(Collection[0]);

            await UnitOfWork.ContentType.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentType>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentType>> SelectAsync(ContentTypeSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentType.SelectAsync(x => x.IsActive == true);
            return new Response<ContentType>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentType>> AnySelectAsync(ContentTypeAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentType.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentType>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}