namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class ContentSettingsManager : ServiceObject<ContentSettings>, IContentSettingsService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentSettings> Validator;

        public ContentSettingsManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentSettings> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ContentSettings>> InsertAsync(ContentSettingsInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentSettings>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentSettings.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentSettings>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentSettings>> UpdateAsync(ContentSettingsUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentSettings.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentSettings>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentSettings.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentSettings>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentSettings>> DeleteAsync(ContentSettingsDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentSettings.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentSettings>(Collection[0]);

            await UnitOfWork.ContentSettings.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentSettings>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentSettings>> SelectAsync(ContentSettingsSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentSettings.SelectAsync(x => x.IsActive == true);
            return new Response<ContentSettings>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentSettings>> AnySelectAsync(ContentSettingsAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentSettings>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}