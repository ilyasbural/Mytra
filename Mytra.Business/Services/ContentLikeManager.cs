namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class ContentLikeManager : BusinessObject<ContentLike>, IContentLikeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentLike> Validator;

        public ContentLikeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentLike> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ContentLike>> InsertAsync(ContentLikeInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentLike>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentLike.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentLike> 
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentLike>> UpdateAsync(ContentLikeUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentLike.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentLike>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentLike.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentLike>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentLike>> DeleteAsync(ContentLikeDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentLike.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentLike>(Collection[0]);

            await UnitOfWork.ContentLike.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentLike>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentLike>> SelectAsync(ContentLikeSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentLike.SelectAsync(x => x.IsActive == true);
            return new Response<ContentLike>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentLike>> AnySelectAsync(ContentLikeAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentLike.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentLike>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}