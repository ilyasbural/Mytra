namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentSettingsManager : BusinessObject<ContentSettings>, IContentSettingsService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ContentSettingsManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ContentSettingsResponse> AddAsync(ContentSettingsInsertDataTransfer Model)
        {
            ContentSettings contentSettings = Mapper.Map<ContentSettings>(Model);
            contentSettings.Id = Guid.NewGuid();
            contentSettings.RegisterDate = DateTime.Now;
            contentSettings.UpdateDate = DateTime.Now;
            contentSettings.IsActive = true;

            await UnitOfWork.ContentSettings.AddAsync(contentSettings);
            await UnitOfWork.SaveChangesAsync();

            return new ContentSettingsResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)



            };
        }
    }
}