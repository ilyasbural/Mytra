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
            int result = await UnitOfWork.SaveChangesAsync();

            return new PermissionDetailResponse 
            { 
                Single = permissionDetail, 
                Success = result,
                Message = "Completed"
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