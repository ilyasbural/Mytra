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

        public async Task<ManagementContactResponse> InsertAsync(ManagementContactInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ManagementContact>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;











            await UnitOfWork.ManagementContact.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementContactResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<ManagementContactResponse> UpdateAsync(ManagementContactUpdateDataTransfer Model)
        {
            List<ManagementContact> DataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id);
            ManagementContact managementContact = Mapper.Map<ManagementContact>(DataSource[0]);
            managementContact.UpdateDate = DateTime.Now;










            await UnitOfWork.ManagementContact.UpdateAsync(managementContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementContactResponse
            {
                Single = managementContact,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementContactResponse> DeleteAsync(ManagementContactDeleteDataTransfer Model)
        {
            List<ManagementContact> managementContactDataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id);
            ManagementContact managementContact = Mapper.Map<ManagementContact>(managementContactDataSource[0]);











            await UnitOfWork.ManagementContact.DeleteAsync(managementContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementContactResponse
            {
                Single = managementContact,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementContactResponse> SelectAsync(ManagementContactSelectDataTransfer Model)
        {
            List<ManagementContact> managementDataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.IsActive == true);
            return new ManagementContactResponse
            {
                List = managementDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ManagementContactResponse> AnyAsync(ManagementContactAnyDataTransfer Model)
        {
            List<ManagementContact> managementContactDataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ManagementContactResponse
            {
                List = managementContactDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}