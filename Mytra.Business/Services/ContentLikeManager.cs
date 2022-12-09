namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentLikeManager : BusinessObject<ContentLike>, IContentLikeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentLike> Validator;

        public ContentLikeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentLike> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<ContentLikeResponse> InsertAsync(ContentLikeInsertDataTransfer Model)
        {
            ContentLike contentLike = Mapper.Map<ContentLike>(Model);
            contentLike.Id = Guid.NewGuid();
            contentLike.RegisterDate = DateTime.Now;
            contentLike.UpdateDate = DateTime.Now;
            contentLike.IsActive = true;

            await UnitOfWork.ContentLike.InsertAsync(contentLike);
            await UnitOfWork.SaveChangesAsync();

            return new ContentLikeResponse { ContentLike = contentLike };
        }

        public async Task<ContentLikeResponse> UpdateAsync(ContentLikeUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentLikeResponse> DeleteAsync(ContentLikeDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentLikeResponse> SelectAsync(ContentLikeSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentLikeResponse> AnyAsync(ContentLikeAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}