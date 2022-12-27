namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class PermissionDetailManager : BusinessObject<PermissionDetail>, IPermissionDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<PermissionDetail> Validator;

        public PermissionDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<PermissionDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<PermissionDetail>> InsertAsync(PermissionDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<PermissionDetail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.PermissionDetail.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<PermissionDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<PermissionDetail>> UpdateAsync(PermissionDetailUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.PermissionDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<PermissionDetail>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.PermissionDetail.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<PermissionDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<PermissionDetail>> DeleteAsync(PermissionDetailDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.PermissionDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<PermissionDetail>(Collection[0]);

            await UnitOfWork.PermissionDetail.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<PermissionDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<PermissionDetail>> SelectAsync(PermissionDetailSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.PermissionDetail.SelectAsync(x => x.IsActive == true);
            return new Response<PermissionDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<PermissionDetail>> AnySelectAsync(PermissionDetailAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.PermissionDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<PermissionDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}