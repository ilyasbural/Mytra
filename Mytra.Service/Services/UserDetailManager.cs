namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class UserDetailManager : ServiceObject<UserDetail>, IUserDetailService
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
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.UserDetail.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

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
            Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<UserDetail>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.UserDetail.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserDetail>> DeleteAsync(UserDetailDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<UserDetail>(Collection[0]);

            await UnitOfWork.UserDetail.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
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