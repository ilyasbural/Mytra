namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

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
            User user = Mapper.Map<User>(Model);
            user.Id = Guid.NewGuid();
            user.RegisterDate = DateTime.Now;
            user.UpdateDate = DateTime.Now;
            user.IsActive = true;

            await UnitOfWork.User.InsertAsync(user);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserResponse 
            { 
                Single = user, 
                Success = result,
                Message = "Completed"
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