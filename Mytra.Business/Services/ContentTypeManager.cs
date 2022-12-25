namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class ContentTypeManager : BusinessObject<ContentType>, IContentTypeService
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


            await UnitOfWork.ContentType.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentType>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentType>> UpdateAsync(ContentTypeUpdateDataTransfer Model)
        {
            List<ContentType> DataSource = await UnitOfWork.ContentType.SelectAsync(x => x.Id == Model.Id);
            ContentType contentType = Mapper.Map<ContentType>(DataSource[0]);
            contentType.UpdateDate = DateTime.Now;





            await UnitOfWork.ContentType.UpdateAsync(contentType);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentType>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentType>> DeleteAsync(ContentTypeDeleteDataTransfer Model)
        {
            List<ContentType> contentTypeDataSource = await UnitOfWork.ContentType.SelectAsync(x => x.Id == Model.Id);
            ContentType contentType = Mapper.Map<ContentType>(contentTypeDataSource[0]);




            await UnitOfWork.ContentType.DeleteAsync(contentType);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentType>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentType>> SelectAsync(ContentTypeSelectDataTransfer Model)
        {
            List<ContentType> contentTypeDataSource = await UnitOfWork.ContentType.SelectAsync(x => x.IsActive == true);
            return new Response<ContentType>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentType>> AnySelectAsync(ContentTypeAnyDataTransfer Model)
        {
            List<ContentType> contentTypeDataSource = await UnitOfWork.ContentType.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentType>
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