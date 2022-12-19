namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

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

        public async Task<ManagementDetailResponse> InsertAsync(ManagementDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ManagementDetail>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;










            await UnitOfWork.ManagementDetail.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementDetailResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<ManagementDetailResponse> UpdateAsync(ManagementDetailUpdateDataTransfer Model)
        {
            List<ManagementDetail> DataSource = await UnitOfWork.ManagementDetail.SelectAsync(x => x.Id == Model.Id);
            ManagementDetail managementDetail = Mapper.Map<ManagementDetail>(DataSource[0]);
            managementDetail.UpdateDate = DateTime.Now;












            await UnitOfWork.ManagementDetail.UpdateAsync(managementDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementDetailResponse
            {
                Single = managementDetail,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementDetailResponse> DeleteAsync(ManagementDetailDeleteDataTransfer Model)
        {
            List<ManagementDetail> managementDetailDataSource = await UnitOfWork.ManagementDetail.SelectAsync(x => x.Id == Model.Id);
            ManagementDetail managementDetail = Mapper.Map<ManagementDetail>(managementDetailDataSource[0]);













            await UnitOfWork.ManagementDetail.DeleteAsync(managementDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementDetailResponse
            {
                Single = managementDetail,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementDetailResponse> SelectAsync(ManagementDetailSelectDataTransfer Model)
        {
            List<ManagementDetail> managementDetailDataSource = await UnitOfWork.ManagementDetail.SelectAsync(x => x.IsActive == true);
            return new ManagementDetailResponse
            {
                List = managementDetailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ManagementDetailResponse> AnyAsync(ManagementDetailAnyDataTransfer Model)
        {
            List<ManagementDetail> managementDetailDataSource = await UnitOfWork.ManagementDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ManagementDetailResponse
            {
                List = managementDetailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}