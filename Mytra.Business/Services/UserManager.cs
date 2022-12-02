namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class UserManager : BusinessObject<User>, IUserService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public UserManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<UserResponse> AddAsync(UserInsertDataTransfer Model)
        {
            User user = Mapper.Map<User>(Model);
            user.Id = Guid.NewGuid();
            user.RegisterDate = DateTime.Now;
            user.UpdateDate = DateTime.Now;
            user.IsActive = true;

            await UnitOfWork.User.AddAsync(user);
            await UnitOfWork.SaveChangesAsync();

            return new UserResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
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