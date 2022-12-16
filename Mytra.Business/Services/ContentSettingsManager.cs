namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentSettingsManager : BusinessObject<ContentSettings>, IContentSettingsService
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

        public async Task<ContentSettingsResponse> InsertAsync(ContentSettingsInsertDataTransfer Model)
        {
            ContentSettings contentSettings = Mapper.Map<ContentSettings>(Model);
            contentSettings.Id = Guid.NewGuid();
            contentSettings.RegisterDate = DateTime.Now;
            contentSettings.UpdateDate = DateTime.Now;
            contentSettings.IsActive = true;

            await UnitOfWork.ContentSettings.InsertAsync(contentSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentSettingsResponse 
            { 
                Single = contentSettings, 
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentSettingsResponse> UpdateAsync(ContentSettingsUpdateDataTransfer Model)
        {
            List<ContentSettings> DataSource = await UnitOfWork.ContentSettings.SelectAsync(x => x.Id == Model.Id);
            ContentSettings contentSettings = Mapper.Map<ContentSettings>(DataSource[0]);
            contentSettings.UpdateDate = DateTime.Now;

            await UnitOfWork.ContentSettings.UpdateAsync(contentSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentSettingsResponse
            {
                Single = contentSettings,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentSettingsResponse> DeleteAsync(ContentSettingsDeleteDataTransfer Model)
        {
            List<ContentSettings> contentSettingsDataSource = await UnitOfWork.ContentSettings.SelectAsync(x => x.Id == Model.Id);
            ContentSettings contentSettings = Mapper.Map<ContentSettings>(contentSettingsDataSource[0]);

            await UnitOfWork.ContentSettings.DeleteAsync(contentSettings);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentSettingsResponse
            {
                Single = contentSettings,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentSettingsResponse> SelectAsync(ContentSettingsSelectDataTransfer Model)
        {
            List<ContentSettings> contentSettingsDataSource = await UnitOfWork.ContentSettings.SelectAsync(x => x.IsActive == true);
            return new ContentSettingsResponse
            {
                List = contentSettingsDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ContentSettingsResponse> AnyAsync(ContentSettingsAnyDataTransfer Model)
        {
            List<ContentSettings> contentSettingsDataSource = await UnitOfWork.ContentSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ContentSettingsResponse
            {
                List = contentSettingsDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}