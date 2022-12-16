namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

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
            ManagementSettings managementSettings = Mapper.Map<ManagementSettings>(Model);
            managementSettings.RegisterDate = DateTime.Now;
            managementSettings.UpdateDate = DateTime.Now;
            managementSettings.IsActive = true;

            await UnitOfWork.ManagementSettings.InsertAsync(managementSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementSettingsResponse 
            { 
                Single = managementSettings, 
                Success = result,
                Message = "Completed"
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