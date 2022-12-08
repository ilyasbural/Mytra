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
            await UnitOfWork.SaveChangesAsync();

            return new UserSettingsResponse { UserSettings = userSettings };
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