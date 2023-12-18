namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class UserEmailManager : ServiceObject<UserEmail>, IUserEmailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<UserEmail> Validator;

        public UserEmailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserEmail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<UserEmail>> InsertAsync(UserEmailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<UserEmail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.UserEmail.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserEmail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserEmail>> UpdateAsync(UserEmailUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.UserEmail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<UserEmail>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.UserEmail.UpdateAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserEmail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserEmail>> DeleteAsync(UserEmailDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.UserEmail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<UserEmail>(Collection[0]);

            await UnitOfWork.UserEmail.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserEmail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserEmail>> SelectAsync(UserEmailSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.UserEmail.SelectAsync(x => x.IsActive == true);
            return new Response<UserEmail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserEmail>> AnySelectAsync(UserEmailAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.UserEmail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<UserEmail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}