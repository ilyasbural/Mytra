namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class ContentPictureManager : BusinessObject<ContentPicture>, IContentPictureService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentPicture> Validator;

        public ContentPictureManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentPicture> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<ContentPictureResponse> InsertAsync(ContentPictureInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentPicture>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.ContentPicture.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentPictureResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<ContentPictureResponse> UpdateAsync(ContentPictureUpdateDataTransfer Model)
        {
            List<ContentPicture> DataSource = await UnitOfWork.ContentPicture.SelectAsync(x => x.Id == Model.Id);
            ContentPicture contentPicture = Mapper.Map<ContentPicture>(DataSource[0]);
            contentPicture.UpdateDate = DateTime.Now;










            await UnitOfWork.ContentPicture.UpdateAsync(contentPicture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentPictureResponse
            {
                Single = contentPicture,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentPictureResponse> DeleteAsync(ContentPictureDeleteDataTransfer Model)
        {
            List<ContentPicture> contentPictureDataSource = await UnitOfWork.ContentPicture.SelectAsync(x => x.Id == Model.Id);
            ContentPicture content = Mapper.Map<ContentPicture>(contentPictureDataSource[0]);










            await UnitOfWork.ContentPicture.DeleteAsync(content);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentPictureResponse
            {
                Single = content,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentPictureResponse> SelectAsync(ContentPictureSelectDataTransfer Model)
        {
            List<ContentPicture> contentPictureDataSource = await UnitOfWork.ContentPicture.SelectAsync(x => x.IsActive == true);
            return new ContentPictureResponse
            {
                List = contentPictureDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ContentPictureResponse> AnyAsync(ContentPictureAnyDataTransfer Model)
        {
            List<ContentPicture> contentPictureDataSource = await UnitOfWork.ContentPicture.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ContentPictureResponse
            {
                List = contentPictureDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}