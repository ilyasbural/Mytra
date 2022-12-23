namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public partial class AnnounceManager : BusinessObject<Announce>, IAnnounceService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Announce> Validator;

        public AnnounceManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Announce> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Announce>> InsertAsync(AnnounceInsertDataTransfer Model)
        {
            Entity = Mapper.Map<Announce>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.Announce.InsertAsync(Entity);
            await UnitOfWork.SaveChangesAsync();

            //await UnitOfWork.Announce.InsertAsync(Entity);
            //Result = await UnitOfWork.SaveChangesAsync();

            //if (Result == 1) { Success = Result; Message = "Data Saved"; } else Message = "Error";

            return new Response<Announce>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Announce>> UpdateAsync(AnnounceUpdateDataTransfer Model)
        {
            List<Announce> announceDataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce announce = Mapper.Map<Announce>(announceDataSource[0]);
            announce.UpdateDate = DateTime.Now;

            await UnitOfWork.Announce.UpdateAsync(announce);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Announce>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Announce>> DeleteAsync(AnnounceDeleteDataTransfer Model)
        {
            List<Announce> announceDataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce announce = Mapper.Map<Announce>(announceDataSource[0]);


            await UnitOfWork.Announce.DeleteAsync(announce);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Announce>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Announce>> SelectAsync(AnnounceSelectDataTransfer Model)
        {
            List<Announce> announceDataSource = await UnitOfWork.Announce.SelectAsync(x => x.IsActive == true);
            return new Response<Announce>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }  

        public async Task<Response<Announce>> AnySelectAsync(AnnounceAnyDataTransfer Model)
        {
            List<Announce> announceDataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Announce>
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