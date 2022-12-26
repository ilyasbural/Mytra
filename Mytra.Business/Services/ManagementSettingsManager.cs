namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class ManagementSettingsManager : BusinessObject<ManagementSettings>, IManagementSettingsService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ManagementSettings> Validator;

        public ManagementSettingsManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagementSettings> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ManagementSettings>> InsertAsync(ManagementSettingsInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ManagementSettings>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;




            await UnitOfWork.ManagementSettings.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementSettings>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementSettings>> UpdateAsync(ManagementSettingsUpdateDataTransfer Model)
        {
            List<ManagementSettings> DataSource = await UnitOfWork.ManagementSettings.SelectAsync(x => x.Id == Model.Id);
            ManagementSettings managementSettings = Mapper.Map<ManagementSettings>(DataSource[0]);
            managementSettings.UpdateDate = DateTime.Now;











            await UnitOfWork.ManagementSettings.UpdateAsync(managementSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementSettings>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ManagementSettings>> DeleteAsync(ManagementSettingsDeleteDataTransfer Model)
        {
            List<ManagementSettings> managementSettingsDataSource = await UnitOfWork.ManagementSettings.SelectAsync(x => x.Id == Model.Id);
            ManagementSettings managementSettings = Mapper.Map<ManagementSettings>(managementSettingsDataSource[0]);













            await UnitOfWork.ManagementSettings.DeleteAsync(managementSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementSettings>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ManagementSettings>> SelectAsync(ManagementSettingsSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementSettings.SelectAsync(x => x.IsActive == true);
            return new Response<ManagementSettings>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementSettings>> AnySelectAsync(ManagementSettingsAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ManagementSettings>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}