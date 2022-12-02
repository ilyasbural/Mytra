namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentPictureManager : BusinessObject<ContentPicture>, IContentPictureService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ContentPictureManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ContentPictureResponse> AddAsync(ContentPictureInsertDataTransfer Model)
        {
            ContentPicture contentPicture = Mapper.Map<ContentPicture>(Model);
            contentPicture.Id = Guid.NewGuid();
            contentPicture.RegisterDate = DateTime.Now;
            contentPicture.UpdateDate = DateTime.Now;
            contentPicture.IsActive = true;

            await UnitOfWork.ContentPicture.AddAsync(contentPicture);
            await UnitOfWork.SaveChangesAsync();

            return new ContentPictureResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<ContentPictureResponse> UpdateAsync(ContentPictureUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentPictureResponse> DeleteAsync(ContentPictureDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentPictureResponse> SelectAsync(ContentPictureSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentPictureResponse> AnyAsync(ContentPictureAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}