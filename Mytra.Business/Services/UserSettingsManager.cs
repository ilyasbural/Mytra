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
                Success = result  
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
                Success = result
            };
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