namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

    public class UserManager : BusinessObject<User>, IUserService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<User> Validator;

        public UserManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<User> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<User>> InsertAsync(UserInsertDataTransfer Model)
        {
            Entity = Mapper.Map<User>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;











            await UnitOfWork.User.InsertAsync(Entity);
            await UnitOfWork.SaveChangesAsync();

            return new Response<User>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<User>> UpdateAsync(UserUpdateDataTransfer Model)
        {
            List<User> DataSource = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id);
            User user = Mapper.Map<User>(DataSource[0]);
            user.UpdateDate = DateTime.Now;













            await UnitOfWork.User.UpdateAsync(user);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<User>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<User>> DeleteAsync(UserDeleteDataTransfer Model)
        {
            List<User> userDataSource = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id);
            User user = Mapper.Map<User>(userDataSource[0]);














            await UnitOfWork.User.DeleteAsync(user);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<User>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<User>> SelectAsync(UserSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.User.SelectAsync(x => x.IsActive == true);
            return new Response<User>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<User>> AnySelectAsync(UserAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<User>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}