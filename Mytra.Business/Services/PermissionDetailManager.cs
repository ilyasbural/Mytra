namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

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

        public async Task<PermissionDetailResponse> InsertAsync(PermissionDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<PermissionDetail>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;










            await UnitOfWork.PermissionDetail.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new PermissionDetailResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<PermissionDetailResponse> UpdateAsync(PermissionDetailUpdateDataTransfer Model)
        {
            List<PermissionDetail> DataSource = await UnitOfWork.PermissionDetail.SelectAsync(x => x.Id == Model.Id);
            PermissionDetail permissionDetail = Mapper.Map<PermissionDetail>(DataSource[0]);
            permissionDetail.UpdateDate = DateTime.Now;










            await UnitOfWork.PermissionDetail.UpdateAsync(permissionDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new PermissionDetailResponse
            {
                Single = permissionDetail,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<PermissionDetailResponse> DeleteAsync(PermissionDetailDeleteDataTransfer Model)
        {
            List<PermissionDetail> permissionDetailDataSource = await UnitOfWork.PermissionDetail.SelectAsync(x => x.Id == Model.Id);
            PermissionDetail permissionDetail = Mapper.Map<PermissionDetail>(permissionDetailDataSource[0]);












            await UnitOfWork.PermissionDetail.DeleteAsync(permissionDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new PermissionDetailResponse
            {
                Single = permissionDetail,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<PermissionDetailResponse> SelectAsync(PermissionDetailSelectDataTransfer Model)
        {
            List<PermissionDetail> permissionDetailDataSource = await UnitOfWork.PermissionDetail.SelectAsync(x => x.IsActive == true);
            return new PermissionDetailResponse
            {
                List = permissionDetailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<PermissionDetailResponse> AnyAsync(PermissionDetailAnyDataTransfer Model)
        {
            List<PermissionDetail> permissionDetailDataSource = await UnitOfWork.PermissionDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new PermissionDetailResponse
            {
                List = permissionDetailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}