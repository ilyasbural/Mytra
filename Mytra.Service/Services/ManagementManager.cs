namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class ManagementManager : ServiceObject<Management>, IManagementService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Management> Validator;

        public ManagementManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Management> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Management>> InsertAsync(ManagementInsertDataTransfer Model)
        {
            Entity = Mapper.Map<Management>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Management.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Management>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Management>> UpdateAsync(ManagementUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Management>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Management.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Management>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Management>> DeleteAsync(ManagementDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Management>(Collection[0]);

            await UnitOfWork.Management.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Management>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Management>> SelectAsync(ManagementSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.Management.SelectAsync(x => x.IsActive == true);
            return new Response<Management>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Management>> AnySelectAsync(ManagementAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Management>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}