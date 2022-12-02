namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentCommentManager : BusinessObject<ContentComment>, IContentCommentService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ContentCommentManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ContentCommentResponse> AddAsync(ContentCommentInsertDataTransfer Model)
        {
            ContentComment contentComment = Mapper.Map<ContentComment>(Model);
            contentComment.Id = Guid.NewGuid();
            contentComment.RegisterDate = DateTime.Now;
            contentComment.UpdateDate = DateTime.Now;
            contentComment.IsActive = true;

            await UnitOfWork.ContentComment.AddAsync(contentComment);
            await UnitOfWork.SaveChangesAsync();

            return new ContentCommentResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<ContentCommentResponse> UpdateAsync(ContentCommentUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}