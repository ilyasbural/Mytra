namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class UserSettingsManager : BusinessObject<UserSettings>, IUserSettingsService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public UserSettingsManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<UserSettingsResponse> AddAsync(UserSettingsInsertDataTransfer Model)
        {
            UserSettings userSettings = Mapper.Map<UserSettings>(Model);
            userSettings.Id = Guid.NewGuid();
            userSettings.RegisterDate = DateTime.Now;
            userSettings.UpdateDate = DateTime.Now;
            userSettings.IsActive = true;

            await UnitOfWork.UserSettings.AddAsync(userSettings);
            await UnitOfWork.SaveChangesAsync();

            return new UserSettingsResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<UserSettingsResponse> UpdateAsync(UserSettingsUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserSettingsResponse> DeleteAsync(UserSettingsDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserSettingsResponse> SelectAsync(UserSettingsSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserSettingsResponse> AnyAsync(UserSettingsAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}