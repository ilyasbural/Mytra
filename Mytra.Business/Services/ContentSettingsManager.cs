namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class ContentSettingsManager : BusinessObject<ContentSettings>, IContentSettingsService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentSettings> Validator;

        public ContentSettingsManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentSettings> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ContentSettings>> InsertAsync(ContentSettingsInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentSettings>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.ContentSettings.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentSettings>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentSettings>> UpdateAsync(ContentSettingsUpdateDataTransfer Model)
        {
            List<ContentSettings> DataSource = await UnitOfWork.ContentSettings.SelectAsync(x => x.Id == Model.Id);
            ContentSettings contentSettings = Mapper.Map<ContentSettings>(DataSource[0]);
            contentSettings.UpdateDate = DateTime.Now;













            await UnitOfWork.ContentSettings.UpdateAsync(contentSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentSettings>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentSettings>> DeleteAsync(ContentSettingsDeleteDataTransfer Model)
        {
            List<ContentSettings> contentSettingsDataSource = await UnitOfWork.ContentSettings.SelectAsync(x => x.Id == Model.Id);
            ContentSettings contentSettings = Mapper.Map<ContentSettings>(contentSettingsDataSource[0]);










            await UnitOfWork.ContentSettings.DeleteAsync(contentSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentSettings>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentSettings>> SelectAsync(ContentSettingsSelectDataTransfer Model)
        {
            List<ContentSettings> contentSettingsDataSource = await UnitOfWork.ContentSettings.SelectAsync(x => x.IsActive == true);
            return new Response<ContentSettings>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentSettings>> AnySelectAsync(ContentSettingsAnyDataTransfer Model)
        {
            List<ContentSettings> contentSettingsDataSource = await UnitOfWork.ContentSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentSettings>
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