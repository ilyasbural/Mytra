namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

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
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ManagementSettings.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

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
            Collection = await UnitOfWork.ManagementSettings.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ManagementSettings>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ManagementSettings.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementSettings>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementSettings>> DeleteAsync(ManagementSettingsDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementSettings.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ManagementSettings>(Collection[0]);

            await UnitOfWork.ManagementSettings.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementSettings>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
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