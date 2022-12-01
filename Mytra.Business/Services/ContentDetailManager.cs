namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentDetailManager : BusinessObject<ContentDetail>, IContentDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ContentDetailManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ContentDetailResponse> AddAsync(ContentDetailInsertDataTransfer Model)
        {
            ContentDetail contentDetail = Mapper.Map<ContentDetail>(Model);
            contentDetail.Id = Guid.NewGuid();
            contentDetail.RegisterDate = DateTime.Now;
            contentDetail.UpdateDate = DateTime.Now;
            contentDetail.IsActive = true;

            await UnitOfWork.ContentDetail.AddAsync(contentDetail);
            await UnitOfWork.SaveChangesAsync();

            return new ContentDetailResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)


            };
        }
    }
}