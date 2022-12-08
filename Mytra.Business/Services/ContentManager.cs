namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentManager : BusinessObject<Content>, IContentService
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
            await UnitOfWork.SaveChangesAsync();

            return new ContentResponse { Content = content };
        }
        
        public async Task<ContentResponse> UpdateAsync(ContentUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentResponse> DeleteAsync(ContentDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentResponse> SelectAsync(ContentSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentResponse> AnyAsync(ContentAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}