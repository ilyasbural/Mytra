namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class UserContactManager : BusinessObject<UserContact>, IUserContactService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<UserContact> Validator;

        public UserContactManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserContact> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<UserContact>> InsertAsync(UserContactInsertDataTransfer Model)
        {
            Entity = Mapper.Map<UserContact>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.UserContact.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserContact>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserContact>> UpdateAsync(UserContactUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.UserContact.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<UserContact>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.UserContact.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserContact>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserContact>> DeleteAsync(UserContactDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.UserContact.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<UserContact>(Collection[0]);

            await UnitOfWork.UserContact.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<UserContact>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserContact>> SelectAsync(UserContactSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.UserContact.SelectAsync(x => x.IsActive == true);
            return new Response<UserContact>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<UserContact>> AnySelectAsync(UserContactAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.UserContact.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<UserContact>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}