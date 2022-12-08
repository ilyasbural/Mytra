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
            await UnitOfWork.SaveChangesAsync();

            return new UserResponse { User = user };
        }

        public async Task<UserResponse> UpdateAsync(UserUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserResponse> DeleteAsync(UserDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserResponse> SelectAsync(UserSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserResponse> AnyAsync(UserAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}