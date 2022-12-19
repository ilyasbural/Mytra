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

        public async Task<ContentLikeResponse> InsertAsync(ContentLikeInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentLike>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.ContentLike.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentLikeResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<ContentLikeResponse> UpdateAsync(ContentLikeUpdateDataTransfer Model)
        {
            List<ContentLike> DataSource = await UnitOfWork.ContentLike.SelectAsync(x => x.Id == Model.Id);
            ContentLike contentLike = Mapper.Map<ContentLike>(DataSource[0]);
            contentLike.UpdateDate = DateTime.Now;










            await UnitOfWork.ContentLike.UpdateAsync(contentLike);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentLikeResponse 
            { 
                Single = contentLike, 
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentLikeResponse> DeleteAsync(ContentLikeDeleteDataTransfer Model)
        {
            List<ContentLike> contentLikeDataSource = await UnitOfWork.ContentLike.SelectAsync(x => x.Id == Model.Id);
            ContentLike contentLike = Mapper.Map<ContentLike>(contentLikeDataSource[0]);












            await UnitOfWork.ContentLike.DeleteAsync(contentLike);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentLikeResponse
            {
                Single = contentLike,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentLikeResponse> SelectAsync(ContentLikeSelectDataTransfer Model)
        {
            List<ContentLike> contentLikeDataSource = await UnitOfWork.ContentLike.SelectAsync(x => x.IsActive == true);
            return new ContentLikeResponse
            {
                List = contentLikeDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ContentLikeResponse> AnyAsync(ContentLikeAnyDataTransfer Model)
        {
            List<ContentLike> contentLikeDataSource = await UnitOfWork.ContentLike.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ContentLikeResponse
            {
                List = contentLikeDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}