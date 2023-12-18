namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class UserSettingsManager : ServiceObject<UserSettings>, IUserSettingsService
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

        public async Task<Response<UserSettings>> InsertAsync(UserSettingsInsertDataTransfer Model)
        {
            Entity = Mapper.Map<UserSettings>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.UserSettings.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserSettings>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserSettings>> UpdateAsync(UserSettingsUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<UserSettings>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.UserSettings.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserSettings>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserSettings>> DeleteAsync(UserSettingsDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<UserSettings>(Collection[0]);

            await UnitOfWork.UserSettings.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserSettings>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserSettings>> SelectAsync(UserSettingsSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.UserSettings.SelectAsync(x => x.IsActive == true);
            return new Response<UserSettings>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserSettings>> AnySelectAsync(UserSettingsAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<UserSettings>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}