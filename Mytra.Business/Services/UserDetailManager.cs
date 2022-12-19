namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

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
            Entity = Mapper.Map<UserDetail>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;











            await UnitOfWork.UserDetail.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserDetailResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
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
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<UserDetailResponse> DeleteAsync(UserDetailDeleteDataTransfer Model)
        {
            List<UserDetail> userDetailDataSource = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id);
            UserDetail userDetail = Mapper.Map<UserDetail>(userDetailDataSource[0]);













            await UnitOfWork.UserDetail.DeleteAsync(userDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserDetailResponse
            {
                Single = userDetail,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<UserDetailResponse> SelectAsync(UserDetailSelectDataTransfer Model)
        {
            List<UserDetail> userDetailDataSource = await UnitOfWork.UserDetail.SelectAsync(x => x.IsActive == true);
            return new UserDetailResponse
            {
                List = userDetailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<UserDetailResponse> AnyAsync(UserDetailAnyDataTransfer Model)
        {
            List<UserDetail> userDetailDataSource = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new UserDetailResponse
            {
                List = userDetailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}