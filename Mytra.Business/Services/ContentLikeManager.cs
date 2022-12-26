namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

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

            await UnitOfWork.ContentLike.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

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
            List<ContentLike> DataSource = await UnitOfWork.ContentLike.SelectAsync(x => x.Id == Model.Id);
            ContentLike contentLike = Mapper.Map<ContentLike>(DataSource[0]);
            contentLike.UpdateDate = DateTime.Now;










            await UnitOfWork.ContentLike.UpdateAsync(contentLike);
            int result = await UnitOfWork.SaveChangesAsync();

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
            List<ContentLike> contentLikeDataSource = await UnitOfWork.ContentLike.SelectAsync(x => x.Id == Model.Id);
            ContentLike contentLike = Mapper.Map<ContentLike>(contentLikeDataSource[0]);












            await UnitOfWork.ContentLike.DeleteAsync(contentLike);
            int result = await UnitOfWork.SaveChangesAsync();

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