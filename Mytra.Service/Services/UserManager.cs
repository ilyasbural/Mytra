namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class UserManager : ServiceObject<User>, IUserService
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

        public async Task<Response<User>> InsertAsync(UserInsertDataTransfer Model)
        {
            Entity = Mapper.Map<User>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.User.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<User>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<User>> UpdateAsync(UserUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<User>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.User.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<User>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<User>> DeleteAsync(UserDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<User>(Collection[0]);

            await UnitOfWork.User.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<User>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<User>> SelectAsync(UserSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.User.SelectAsync(x => x.IsActive == true);
            return new Response<User>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<User>> AnySelectAsync(UserAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<User>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}