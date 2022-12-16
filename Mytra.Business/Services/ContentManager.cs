namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public partial class ContentManager : BusinessObject<Content>, IContentService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Content> Validator;

        public ContentManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Content> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<ContentResponse> InsertAsync(ContentInsertDataTransfer Model)
        {
            Content content = Mapper.Map<Content>(Model);
            content.Id = Guid.NewGuid();
            content.RegisterDate = DateTime.Now;
            content.UpdateDate = DateTime.Now;
            content.IsActive = true;

            await UnitOfWork.Content.InsertAsync(content);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentResponse 
            { 
                Single = content, 
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentResponse> UpdateAsync(ContentUpdateDataTransfer Model)
        {
            List<Content> DataSource = await UnitOfWork.Content.SelectAsync(x => x.Id == Model.Id);
            Content content = Mapper.Map<Content>(DataSource[0]);
            content.UpdateDate = DateTime.Now;

            await UnitOfWork.Content.UpdateAsync(content);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentResponse
            {
                Single = content,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentResponse> DeleteAsync(ContentDeleteDataTransfer Model)
        {
            List<Content> contentDataSource = await UnitOfWork.Content.SelectAsync(x => x.Id == Model.Id);
            Content content = Mapper.Map<Content>(contentDataSource[0]);

            await UnitOfWork.Content.DeleteAsync(content);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentResponse
            {
                Single = content,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ContentResponse> SelectAsync(ContentSelectDataTransfer Model)
        {
            List<Content> contentDataSource = await UnitOfWork.Content.SelectAsync(x => x.IsActive == true);
            return new ContentResponse
            {
                List = contentDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ContentResponse> AnyAsync(ContentAnyDataTransfer Model)
        {
            List<Content> contentDataSource = await UnitOfWork.Content.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ContentResponse
            {
                List = contentDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}