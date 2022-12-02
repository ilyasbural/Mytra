namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementSettingsManager : BusinessObject<ManagementSettings>, IManagementSettingsService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ManagementSettingsManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ManagementSettingsResponse> AddAsync(ManagementSettingsInsertDataTransfer Model)
        {
            ManagementSettings managementSettings = Mapper.Map<ManagementSettings>(Model);
            managementSettings.Id = Guid.NewGuid();
            managementSettings.RegisterDate = DateTime.Now;
            managementSettings.UpdateDate = DateTime.Now;
            managementSettings.IsActive = true;

            await UnitOfWork.ManagementSettings.AddAsync(managementSettings);
            await UnitOfWork.SaveChangesAsync();

            return new ManagementSettingsResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
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
    }
}