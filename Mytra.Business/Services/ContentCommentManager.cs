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

        public async Task<ContentCommentResponse> InsertAsync(ContentCommentInsertDataTransfer Model)
        {
            ContentComment contentComment = Mapper.Map<ContentComment>(Model);
            contentComment.Id = Guid.NewGuid();
            contentComment.RegisterDate = DateTime.Now;
            contentComment.UpdateDate = DateTime.Now;
            contentComment.IsActive = true;

            await UnitOfWork.ContentComment.InsertAsync(contentComment);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentCommentResponse 
            { 
                Single = contentComment,
                Success = result  
            };
        }

        public async Task<ContentCommentResponse> UpdateAsync(ContentCommentUpdateDataTransfer Model)
        {
            List<ContentComment> DataSource = await UnitOfWork.ContentComment.SelectAsync(x => x.Id == Model.Id);
            ContentComment contentComment = Mapper.Map<ContentComment>(DataSource[0]);
            contentComment.UpdateDate = DateTime.Now;

            await UnitOfWork.ContentComment.UpdateAsync(contentComment);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentCommentResponse
            {
                Single = contentComment,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentCommentResponse> DeleteAsync(ContentCommentDeleteDataTransfer Model)
        {
            List<ContentComment> announceDataSource = await UnitOfWork.ContentComment.SelectAsync(x => x.Id == Model.Id);
            ContentComment contentComment = Mapper.Map<ContentComment>(announceDataSource[0]);

            await UnitOfWork.ContentComment.DeleteAsync(contentComment);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentCommentResponse
            {
                Single = contentComment,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentCommentResponse> SelectAsync(ContentCommentSelectDataTransfer Model)
        {
            List<ContentComment> contentCommentDataSource = await UnitOfWork.ContentComment.SelectAsync(x => x.IsActive == true);
            return new ContentCommentResponse
            {
                List = contentCommentDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ContentCommentResponse> AnyAsync(ContentCommentAnyDataTransfer Model)
        {
            List<ContentComment> contentCommentDataSource = await UnitOfWork.ContentComment.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ContentCommentResponse
            {
                List = contentCommentDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}