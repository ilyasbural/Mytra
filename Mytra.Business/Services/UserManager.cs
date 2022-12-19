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

        public async Task<UserResponse> InsertAsync(UserInsertDataTransfer Model)
        {
            Entity = Mapper.Map<User>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            Validations = Validator.Validate(Entity);











            await UnitOfWork.User.InsertAsync(Entity);
            await UnitOfWork.SaveChangesAsync();

            return new UserResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<UserResponse> UpdateAsync(UserUpdateDataTransfer Model)
        {
            List<User> DataSource = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id);
            User user = Mapper.Map<User>(DataSource[0]);
            user.UpdateDate = DateTime.Now;













            await UnitOfWork.User.UpdateAsync(user);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserResponse 
            {
                Single = user,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<UserResponse> DeleteAsync(UserDeleteDataTransfer Model)
        {
            List<User> userDataSource = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id);
            User user = Mapper.Map<User>(userDataSource[0]);














            await UnitOfWork.User.DeleteAsync(user);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserResponse
            {
                Single = user,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<UserResponse> SelectAsync(UserSelectDataTransfer Model)
        {
            List<User> userDataSource = await UnitOfWork.User.SelectAsync(x => x.IsActive == true);
            return new UserResponse
            {
                List = userDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<UserResponse> AnyAsync(UserAnyDataTransfer Model)
        {
            List<User> userDataSource = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new UserResponse
            {
                List = userDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}