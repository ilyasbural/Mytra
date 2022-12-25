namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class ContentDetailManager : BusinessObject<ContentDetail>, IContentDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentDetail> Validator;

        public ContentDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ContentDetail>> InsertAsync(ContentDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentDetail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.ContentDetail.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentDetail>> UpdateAsync(ContentDetailUpdateDataTransfer Model)
        {
            List<ContentDetail> DataSource = await UnitOfWork.ContentDetail.SelectAsync(x => x.Id == Model.Id);
            ContentDetail contentDetail = Mapper.Map<ContentDetail>(DataSource[0]);
            contentDetail.UpdateDate = DateTime.Now;












            await UnitOfWork.ContentDetail.UpdateAsync(contentDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentDetail>> DeleteAsync(ContentDetailDeleteDataTransfer Model)
        {
            List<ContentDetail> contentDetailDataSource = await UnitOfWork.ContentDetail.SelectAsync(x => x.Id == Model.Id);
            ContentDetail contentDetail = Mapper.Map<ContentDetail>(contentDetailDataSource[0]);




            await UnitOfWork.ContentDetail.DeleteAsync(contentDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentDetail>> SelectAsync(ContentDetailSelectDataTransfer Model)
        {
            List<ContentDetail> contentDetailDataSource = await UnitOfWork.ContentDetail.SelectAsync(x => x.IsActive == true);
            return new Response<ContentDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ContentDetail>> AnySelectAsync(ContentDetailAnyDataTransfer Model)
        {
            List<ContentDetail> contentDetailDataSource = await UnitOfWork.ContentDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }
    }
}