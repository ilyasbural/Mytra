namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class ContentCommentManager : BusinessObject<ContentComment>, IContentCommentService
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
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.ContentComment.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentComment>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentComment>> UpdateAsync(ContentCommentUpdateDataTransfer Model)
        {
            List<ContentComment> DataSource = await UnitOfWork.ContentComment.SelectAsync(x => x.Id == Model.Id);
            ContentComment contentComment = Mapper.Map<ContentComment>(DataSource[0]);
            contentComment.UpdateDate = DateTime.Now;




            await UnitOfWork.ContentComment.UpdateAsync(contentComment);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentComment>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentComment>> DeleteAsync(ContentCommentDeleteDataTransfer Model)
        {
            List<ContentComment> announceDataSource = await UnitOfWork.ContentComment.SelectAsync(x => x.Id == Model.Id);
            ContentComment contentComment = Mapper.Map<ContentComment>(announceDataSource[0]);



            await UnitOfWork.ContentComment.DeleteAsync(contentComment);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentComment>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentComment>> SelectAsync(ContentCommentSelectDataTransfer Model)
        {
            List<ContentComment> contentCommentDataSource = await UnitOfWork.ContentComment.SelectAsync(x => x.IsActive == true);
            return new Response<ContentComment>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentComment>> AnySelectAsync(ContentCommentAnyDataTransfer Model)
        {
            List<ContentComment> contentCommentDataSource = await UnitOfWork.ContentComment.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentComment>
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