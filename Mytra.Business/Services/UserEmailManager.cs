namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class UserEmailManager : BusinessObject<UserEmail>, IUserEmailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<UserEmail> Validator;

        public UserEmailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserEmail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<UserEmail>> InsertAsync(UserEmailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<UserEmail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;











            await UnitOfWork.UserEmail.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserEmail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserEmail>> UpdateAsync(UserEmailUpdateDataTransfer Model)
        {
            List<UserEmail> DataSource = await UnitOfWork.UserEmail.SelectAsync(x => x.Id == Model.Id);
            UserEmail userEmail = Mapper.Map<UserEmail>(DataSource[0]);
            userEmail.UpdateDate = DateTime.Now;











            await UnitOfWork.UserEmail.UpdateAsync(userEmail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserEmail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserEmail>> DeleteAsync(UserEmailDeleteDataTransfer Model)
        {
            List<UserEmail> userEmailDataSource = await UnitOfWork.UserEmail.SelectAsync(x => x.Id == Model.Id);
            UserEmail userEmail = Mapper.Map<UserEmail>(userEmailDataSource[0]);













            await UnitOfWork.UserEmail.DeleteAsync(userEmail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserEmail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserEmail>> SelectAsync(UserEmailSelectDataTransfer Model)
        {
            List<UserEmail> userEmailDataSource = await UnitOfWork.UserEmail.SelectAsync(x => x.IsActive == true);
            return new Response<UserEmail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserEmail>> AnySelectAsync(UserEmailAnyDataTransfer Model)
        {
            List<UserEmail> userEmailDataSource = await UnitOfWork.UserEmail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<UserEmail>
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