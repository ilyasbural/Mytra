namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentLikeManager : BusinessObject<ContentLike>, IContentLikeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ContentLikeManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ContentLikeResponse> AddAsync(ContentLikeInsertDataTransfer Model)
        {
            ContentLike contentLike = Mapper.Map<ContentLike>(Model);
            contentLike.Id = Guid.NewGuid();
            contentLike.RegisterDate = DateTime.Now;
            contentLike.UpdateDate = DateTime.Now;
            contentLike.IsActive = true;

            await UnitOfWork.ContentLike.AddAsync(contentLike);
            await UnitOfWork.SaveChangesAsync();

            return new ContentLikeResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<ContentLikeResponse> UpdateAsync(ContentLikeUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}