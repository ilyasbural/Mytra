namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentTypeManager : BusinessObject<ContentType>, IContentTypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentType> Validator;

        public ContentTypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentType> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<ContentTypeResponse> AddAsync(ContentTypeInsertDataTransfer Model)
        {
            ContentType contentType = Mapper.Map<ContentType>(Model);
            contentType.Id = Guid.NewGuid();
            contentType.RegisterDate = DateTime.Now;
            contentType.UpdateDate = DateTime.Now;
            contentType.IsActive = true;

            await UnitOfWork.ContentType.AddAsync(contentType);
            await UnitOfWork.SaveChangesAsync();

            return new ContentTypeResponse { ContentType = contentType };
        }

        public async Task<ContentTypeResponse> UpdateAsync(ContentTypeUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentTypeResponse> DeleteAsync(ContentTypeDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentTypeResponse> SelectAsync(ContentTypeSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentTypeResponse> AnyAsync(ContentTypeAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}