namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class ContentCommentManager : ServiceObject<ContentComment>, IContentCommentService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentComment> Validator;

        public ContentCommentManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentComment> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ContentComment>> InsertAsync(ContentCommentInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentComment>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentComment.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentComment>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentComment>> UpdateAsync(ContentCommentUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentComment.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentComment>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentComment.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentComment>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentComment>> DeleteAsync(ContentCommentDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentComment.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentComment>(Collection[0]);

            await UnitOfWork.ContentComment.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentComment>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentComment>> SelectAsync(ContentCommentSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentComment.SelectAsync(x => x.IsActive == true);
            return new Response<ContentComment>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentComment>> AnySelectAsync(ContentCommentAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentComment.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentComment>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}