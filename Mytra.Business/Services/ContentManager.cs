namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

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
            Entity = Mapper.Map<Content>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.Content.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
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