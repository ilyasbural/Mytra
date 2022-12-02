namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementDetailManager : BusinessObject<ManagementDetail>, IManagementDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ManagementDetailManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ManagementDetailResponse> AddAsync(ManagementDetailInsertDataTransfer Model)
        {
            ManagementDetail managementDetail = Mapper.Map<ManagementDetail>(Model);
            managementDetail.Id = Guid.NewGuid();
            managementDetail.RegisterDate = DateTime.Now;
            managementDetail.UpdateDate = DateTime.Now;
            managementDetail.IsActive = true;

            await UnitOfWork.ManagementDetail.AddAsync(managementDetail);
            await UnitOfWork.SaveChangesAsync();

            return new ManagementDetailResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<ManagementDetailResponse> UpdateAsync(ManagementDetailUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}