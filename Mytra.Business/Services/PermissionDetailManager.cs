namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

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
            PermissionDetail permissionDetail = Mapper.Map<PermissionDetail>(Model);
            permissionDetail.Id = Guid.NewGuid();
            permissionDetail.RegisterDate = DateTime.Now;
            permissionDetail.UpdateDate = DateTime.Now;
            permissionDetail.IsActive = true;

            await UnitOfWork.PermissionDetail.InsertAsync(permissionDetail);
            await UnitOfWork.SaveChangesAsync();

            return new PermissionDetailResponse { PermissionDetail = permissionDetail };
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

        public async Task<PermissionDetailResponse> AnyAsync(PermissionDetailAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}