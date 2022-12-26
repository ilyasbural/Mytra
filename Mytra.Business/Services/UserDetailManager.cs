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

        public async Task<Response<UserDetail>> InsertAsync(UserDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<UserDetail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;











            await UnitOfWork.UserDetail.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserDetail>> UpdateAsync(UserDetailUpdateDataTransfer Model)
        {
            List<UserDetail> DataSource = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id);
            UserDetail userDetail = Mapper.Map<UserDetail>(DataSource[0]);
            userDetail.UpdateDate = DateTime.Now;












            await UnitOfWork.UserDetail.UpdateAsync(userDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserDetail>> DeleteAsync(UserDetailDeleteDataTransfer Model)
        {
            List<UserDetail> userDetailDataSource = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id);
            UserDetail userDetail = Mapper.Map<UserDetail>(userDetailDataSource[0]);













            await UnitOfWork.UserDetail.DeleteAsync(userDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<UserDetail>> SelectAsync(UserDetailSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.IsActive == true);
            return new Response<UserDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserDetail>> AnySelectAsync(UserDetailAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<UserDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}