namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentCommentManager : BusinessObject<ContentComment>, IContentCommentService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentComment> Validator;

        public ContentCommentManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentComment> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
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

        public async Task<ContentCommentResponse> DeleteAsync(ContentCommentDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentCommentResponse> SelectAsync(ContentCommentSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentCommentResponse> AnyAsync(ContentCommentAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}