namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class PermissionManager : ServiceObject<Permission>, IPermissionService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Permission> Validator;

        public PermissionManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Permission> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Permission>> InsertAsync(PermissionInsertDataTransfer Model)
        {
            Entity = Mapper.Map<Permission>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Permission.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Permission>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Permission>> UpdateAsync(PermissionUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.Permission.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Permission>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Permission.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Permission>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Permission>> DeleteAsync(PermissionDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.Permission.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Permission>(Collection[0]);

            await UnitOfWork.Permission.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Permission>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Permission>> SelectAsync(PermissionSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.Permission.SelectAsync(x => x.IsActive == true);
            return new Response<Permission>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Permission>> AnySelectAsync(PermissionAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.Permission.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Permission>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}