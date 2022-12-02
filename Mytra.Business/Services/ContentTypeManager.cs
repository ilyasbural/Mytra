namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentTypeManager : BusinessObject<ContentType>, IContentTypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ContentTypeManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ContentTypeResponse> AddAsync(ContentTypeInsertDataTransfer Model)
        {
            ContentType contentType = Mapper.Map<ContentType>(Model);
            contentType.Id = Guid.NewGuid();
            contentType.RegisterDate = DateTime.Now;
            contentType.UpdateDate = DateTime.Now;
            contentType.IsActive = true;

            await UnitOfWork.ContentType.AddAsync(contentType);
            await UnitOfWork.SaveChangesAsync();

            return new ContentTypeResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<ContentTypeResponse> UpdateAsync(ContentTypeUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}