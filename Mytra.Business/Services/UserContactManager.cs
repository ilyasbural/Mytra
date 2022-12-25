namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class UserContactManager : BusinessObject<UserContact>, IUserContactService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<UserContact> Validator;

        public UserContactManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserContact> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<UserContact>> InsertAsync(UserContactInsertDataTransfer Model)
        {
            Entity = Mapper.Map<UserContact>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;









            await UnitOfWork.UserContact.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserContact>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserContact>> UpdateAsync(UserContactUpdateDataTransfer Model)
        {
            List<UserContact> DataSource = await UnitOfWork.UserContact.SelectAsync(x => x.Id == Model.Id);
            UserContact userContact = Mapper.Map<UserContact>(DataSource[0]);
            userContact.UpdateDate = DateTime.Now;









            await UnitOfWork.UserContact.UpdateAsync(userContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserContact>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserContact>> DeleteAsync(UserContactDeleteDataTransfer Model)
        {
            List<UserContact> userContactDataSource = await UnitOfWork.UserContact.SelectAsync(x => x.Id == Model.Id);
            UserContact userContact = Mapper.Map<UserContact>(userContactDataSource[0]);








            await UnitOfWork.UserContact.DeleteAsync(userContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserContact>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserContact>> SelectAsync(UserContactSelectDataTransfer Model)
        {
            List<UserContact> userContactDataSource = await UnitOfWork.UserContact.SelectAsync(x => x.IsActive == true);
            return new Response<UserContact>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserContact>> AnySelectAsync(UserContactAnyDataTransfer Model)
        {
            List<UserContact> userContactDataSource = await UnitOfWork.UserContact.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<UserContact>
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