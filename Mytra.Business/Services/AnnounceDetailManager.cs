namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public partial class AnnounceDetailManager : BusinessObject<AnnounceDetail>, IAnnounceDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<AnnounceDetail> Validator;

        public AnnounceDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<AnnounceDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<AnnounceDetail>> InsertAsync(AnnounceDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<AnnounceDetail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.AnnounceDetail.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<AnnounceDetail> 
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<AnnounceDetail>> UpdateAsync(AnnounceDetailUpdateDataTransfer Model)
        {
            List<AnnounceDetail> DataSource = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.Id == Model.Id);
            AnnounceDetail picture = Mapper.Map<AnnounceDetail>(DataSource[0]);
            picture.UpdateDate = DateTime.Now;










            await UnitOfWork.AnnounceDetail.UpdateAsync(picture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<AnnounceDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }      

        public async Task<Response<AnnounceDetail>> DeleteAsync(AnnounceDetailDeleteDataTransfer Model)
        {
            List<AnnounceDetail> announceDetailDataSource = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.Id == Model.Id);
            AnnounceDetail announceDetail = Mapper.Map<AnnounceDetail>(announceDetailDataSource[0]);











            await UnitOfWork.AnnounceDetail.DeleteAsync(announceDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<AnnounceDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }  

        public async Task<Response<AnnounceDetail>> SelectAsync(AnnounceDetailSelectDataTransfer Model)
        {
            List<AnnounceDetail> announceDetailDataSource = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.IsActive == true);
            return new Response<AnnounceDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<AnnounceDetail>> AnyAsync(AnnounceDetailAnyDataTransfer Model)
        {
            List<AnnounceDetail> announceDetailDataSource = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<AnnounceDetail>
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