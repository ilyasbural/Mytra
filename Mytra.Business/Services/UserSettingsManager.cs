namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class UserSettingsManager : BusinessObject<UserSettings>, IUserSettingsService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<UserSettings> Validator;

        public UserSettingsManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserSettings> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<UserSettingsResponse> InsertAsync(UserSettingsInsertDataTransfer Model)
        {
            UserSettings userSettings = Mapper.Map<UserSettings>(Model);
            userSettings.RegisterDate = DateTime.Now;
            userSettings.UpdateDate = DateTime.Now;
            userSettings.IsActive = true;

            await UnitOfWork.UserSettings.InsertAsync(userSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserSettingsResponse 
            { 
                Single = userSettings, 
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<UserSettingsResponse> UpdateAsync(UserSettingsUpdateDataTransfer Model)
        {
            List<UserSettings> DataSource = await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id);
            UserSettings userSettings = Mapper.Map<UserSettings>(DataSource[0]);
            userSettings.UpdateDate = DateTime.Now;

            await UnitOfWork.UserSettings.UpdateAsync(userSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserSettingsResponse 
            {
                Single = userSettings,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<UserSettingsResponse> DeleteAsync(UserSettingsDeleteDataTransfer Model)
        {
            List<UserSettings> userSettingsDataSource = await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id);
            UserSettings userSettings = Mapper.Map<UserSettings>(userSettingsDataSource[0]);

            await UnitOfWork.UserSettings.DeleteAsync(userSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserSettingsResponse
            {
                Single = userSettings,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<UserSettingsResponse> SelectAsync(UserSettingsSelectDataTransfer Model)
        {
            List<UserSettings> userSettingDataSource = await UnitOfWork.UserSettings.SelectAsync(x => x.IsActive == true);
            return new UserSettingsResponse
            {
                List = userSettingDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<UserSettingsResponse> AnyAsync(UserSettingsAnyDataTransfer Model)
        {
            List<UserSettings> userSettingsDataSource = await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new UserSettingsResponse
            {
                List = userSettingsDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}