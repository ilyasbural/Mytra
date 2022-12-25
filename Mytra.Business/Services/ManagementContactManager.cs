namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class ManagementContactManager : BusinessObject<ManagementContact>, IManagementContactService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ManagementContact> Validator;

        public ManagementContactManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagementContact> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ManagementContact>> InsertAsync(ManagementContactInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ManagementContact>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;











            await UnitOfWork.ManagementContact.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementContact>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ManagementContact>> UpdateAsync(ManagementContactUpdateDataTransfer Model)
        {
            List<ManagementContact> DataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id);
            ManagementContact managementContact = Mapper.Map<ManagementContact>(DataSource[0]);
            managementContact.UpdateDate = DateTime.Now;










            await UnitOfWork.ManagementContact.UpdateAsync(managementContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementContact>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ManagementContact>> DeleteAsync(ManagementContactDeleteDataTransfer Model)
        {
            List<ManagementContact> managementContactDataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id);
            ManagementContact managementContact = Mapper.Map<ManagementContact>(managementContactDataSource[0]);











            await UnitOfWork.ManagementContact.DeleteAsync(managementContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementContact>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ManagementContact>> SelectAsync(ManagementContactSelectDataTransfer Model)
        {
            List<ManagementContact> managementDataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.IsActive == true);
            return new Response<ManagementContact>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<ManagementContact>> AnySelectAsync(ManagementContactAnyDataTransfer Model)
        {
            List<ManagementContact> managementContactDataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ManagementContact>
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