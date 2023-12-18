namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class ManagementContactManager : ServiceObject<ManagementContact>, IManagementContactService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ManagementContact> Validator;

        public ManagementContactManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagementContact> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ManagementContact>> InsertAsync(ManagementContactInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ManagementContact>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ManagementContact.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementContact>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementContact>> UpdateAsync(ManagementContactUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ManagementContact>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ManagementContact.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementContact>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementContact>> DeleteAsync(ManagementContactDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ManagementContact>(Collection[0]);

            await UnitOfWork.ManagementContact.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementContact>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementContact>> SelectAsync(ManagementContactSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementContact.SelectAsync(x => x.IsActive == true);
            return new Response<ManagementContact>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementContact>> AnySelectAsync(ManagementContactAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ManagementContact>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}