namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

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
            ManagementDetail managementDetail = Mapper.Map<ManagementDetail>(Model);
            managementDetail.RegisterDate = DateTime.Now;
            managementDetail.UpdateDate = DateTime.Now;
            managementDetail.IsActive = true;

            await UnitOfWork.ManagementDetail.InsertAsync(managementDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementDetailResponse 
            { 
                Single = managementDetail, 
                Success = result
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
                Success = result
            };
        }

        public async Task<ManagementDetailResponse> DeleteAsync(ManagementDetailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementDetailResponse> SelectAsync(ManagementDetailSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementDetailResponse> AnyAsync(ManagementDetailAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}