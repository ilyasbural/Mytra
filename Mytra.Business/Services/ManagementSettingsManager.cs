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

        public async Task<ManagementSettingsResponse> InsertAsync(ManagementSettingsInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ManagementSettings>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;










            await UnitOfWork.ManagementSettings.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementSettingsResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<ManagementSettingsResponse> UpdateAsync(ManagementSettingsUpdateDataTransfer Model)
        {
            List<ManagementSettings> DataSource = await UnitOfWork.ManagementSettings.SelectAsync(x => x.Id == Model.Id);
            ManagementSettings managementSettings = Mapper.Map<ManagementSettings>(DataSource[0]);
            managementSettings.UpdateDate = DateTime.Now;











            await UnitOfWork.ManagementSettings.UpdateAsync(managementSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementSettingsResponse
            {
                Single = managementSettings,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementSettingsResponse> DeleteAsync(ManagementSettingsDeleteDataTransfer Model)
        {
            List<ManagementSettings> managementSettingsDataSource = await UnitOfWork.ManagementSettings.SelectAsync(x => x.Id == Model.Id);
            ManagementSettings managementSettings = Mapper.Map<ManagementSettings>(managementSettingsDataSource[0]);













            await UnitOfWork.ManagementSettings.DeleteAsync(managementSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementSettingsResponse
            {
                Single = managementSettings,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementSettingsResponse> SelectAsync(ManagementSettingsSelectDataTransfer Model)
        {
            List<ManagementSettings> managementSettingDataSource = await UnitOfWork.ManagementSettings.SelectAsync(x => x.IsActive == true);
            return new ManagementSettingsResponse
            {
                List = managementSettingDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ManagementSettingsResponse> AnyAsync(ManagementSettingsAnyDataTransfer Model)
        {
            List<ManagementSettings> managementSettingsDataSource = await UnitOfWork.ManagementSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ManagementSettingsResponse
            {
                List = managementSettingsDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}