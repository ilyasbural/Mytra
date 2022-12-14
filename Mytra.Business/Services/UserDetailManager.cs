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

        public async Task<UserDetailResponse> InsertAsync(UserDetailInsertDataTransfer Model)
        {
            UserDetail userDetail = Mapper.Map<UserDetail>(Model);
            userDetail.RegisterDate = DateTime.Now;
            userDetail.UpdateDate = DateTime.Now;
            userDetail.IsActive = true;

            await UnitOfWork.UserDetail.InsertAsync(userDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserDetailResponse 
            { 
                Single = userDetail, 
                Success = result 
            };
        }

        public async Task<UserDetailResponse> UpdateAsync(UserDetailUpdateDataTransfer Model)
        {
            List<UserDetail> DataSource = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id);
            UserDetail userDetail = Mapper.Map<UserDetail>(DataSource[0]);
            userDetail.UpdateDate = DateTime.Now;

            await UnitOfWork.UserDetail.UpdateAsync(userDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserDetailResponse 
            { 
                Single = userDetail, 
                Success = result 
            };
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