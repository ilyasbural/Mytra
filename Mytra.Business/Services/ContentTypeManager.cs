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

        public async Task<ContentTypeResponse> InsertAsync(ContentTypeInsertDataTransfer Model)
        {
            ContentType contentType = Mapper.Map<ContentType>(Model);
            contentType.Id = Guid.NewGuid();
            contentType.RegisterDate = DateTime.Now;
            contentType.UpdateDate = DateTime.Now;
            contentType.IsActive = true;

            await UnitOfWork.ContentType.InsertAsync(contentType);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentTypeResponse 
            { 
                Single = contentType, 
                Success = result 
            };
        }

        public async Task<ContentTypeResponse> UpdateAsync(ContentTypeUpdateDataTransfer Model)
        {
            List<ContentType> DataSource = await UnitOfWork.ContentType.SelectAsync(x => x.Id == Model.Id);
            ContentType contentType = Mapper.Map<ContentType>(DataSource[0]);
            contentType.UpdateDate = DateTime.Now;

            await UnitOfWork.ContentType.UpdateAsync(contentType);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentTypeResponse
            {
                Single = contentType,
                Success = result
            };
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