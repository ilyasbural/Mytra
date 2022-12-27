namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class ManagementDetailManager : BusinessObject<ManagementDetail>, IManagementDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ManagementDetail> Validator;

        public ManagementDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagementDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ManagementDetail>> InsertAsync(ManagementDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ManagementDetail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ManagementDetail.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementDetail>> UpdateAsync(ManagementDetailUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ManagementDetail>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ManagementDetail.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementDetail>> DeleteAsync(ManagementDetailDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ManagementDetail>(Collection[0]);

            await UnitOfWork.ManagementDetail.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ManagementDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementDetail>> SelectAsync(ManagementDetailSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementDetail.SelectAsync(x => x.IsActive == true);
            return new Response<ManagementDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ManagementDetail>> AnySelectAsync(ManagementDetailAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.ManagementDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ManagementDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}