namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class UserDetailManager : BusinessObject<UserDetail>, IUserDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public UserDetailManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<UserDetailResponse> AddAsync(UserDetailInsertDataTransfer Model)
        {
            UserDetail userDetail = Mapper.Map<UserDetail>(Model);
            userDetail.Id = Guid.NewGuid();
            userDetail.RegisterDate = DateTime.Now;
            userDetail.UpdateDate = DateTime.Now;
            userDetail.IsActive = true;

            await UnitOfWork.UserDetail.AddAsync(userDetail);
            await UnitOfWork.SaveChangesAsync();

            return new UserDetailResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<UserDetailResponse> UpdateAsync(UserDetailUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDetailResponse> DeleteAsync(UserDetailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}