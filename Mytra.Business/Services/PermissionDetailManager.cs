namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class PermissionDetailManager : BusinessObject<PermissionDetail>, IPermissionDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public PermissionDetailManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<PermissionDetailResponse> AddAsync(PermissionDetailInsertDataTransfer Model)
        {
            PermissionDetail permissionDetail = Mapper.Map<PermissionDetail>(Model);
            permissionDetail.Id = Guid.NewGuid();
            permissionDetail.RegisterDate = DateTime.Now;
            permissionDetail.UpdateDate = DateTime.Now;
            permissionDetail.IsActive = true;

            await UnitOfWork.PermissionDetail.AddAsync(permissionDetail);
            await UnitOfWork.SaveChangesAsync();

            return new PermissionDetailResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<PermissionDetailResponse> UpdateAsync(PermissionDetailUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PermissionDetailResponse> DeleteAsync(PermissionDetailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PermissionDetailResponse> SelectAsync(PermissionDetailSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}