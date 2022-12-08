namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class UserDetailManager : BusinessObject<UserDetail>, IUserDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<UserDetail> Validator;

        public UserDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<UserDetailResponse> AddAsync(UserDetailInsertDataTransfer Model)
        {
            UserDetail userDetail = Mapper.Map<UserDetail>(Model);
            userDetail.RegisterDate = DateTime.Now;
            userDetail.UpdateDate = DateTime.Now;
            userDetail.IsActive = true;

            await UnitOfWork.UserDetail.AddAsync(userDetail);
            await UnitOfWork.SaveChangesAsync();

            return new UserDetailResponse { UserDetail = userDetail };
        }

        public async Task<UserDetailResponse> UpdateAsync(UserDetailUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDetailResponse> DeleteAsync(UserDetailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDetailResponse> SelectAsync(UserDetailSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDetailResponse> AnyAsync(UserDetailAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}