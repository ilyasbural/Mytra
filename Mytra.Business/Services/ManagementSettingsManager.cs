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
            await UnitOfWork.SaveChangesAsync();

            return new ManagementSettingsResponse { ManagementSettings= managementSettings };
        }

        public async Task<ManagementSettingsResponse> UpdateAsync(ManagementSettingsUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementSettingsResponse> DeleteAsync(ManagementSettingsDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementSettingsResponse> SelectAsync(ManagementSettingsSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementSettingsResponse> AnyAsync(ManagementSettingsAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}