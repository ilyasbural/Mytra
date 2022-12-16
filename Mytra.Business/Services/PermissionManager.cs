namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class PermissionManager : BusinessObject<Permission>, IPermissionService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Permission> Validator;

        public PermissionManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Permission> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<PermissionResponse> InsertAsync(PermissionInsertDataTransfer Model)
        {
            Permission permission = Mapper.Map<Permission>(Model);
            permission.Id = Guid.NewGuid();
            permission.RegisterDate = DateTime.Now;
            permission.UpdateDate = DateTime.Now;
            permission.IsActive = true;

            await UnitOfWork.Permission.InsertAsync(permission);
            int result = await UnitOfWork.SaveChangesAsync();

            return new PermissionResponse 
            { 
                Single = permission, 
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<PermissionResponse> UpdateAsync(PermissionUpdateDataTransfer Model)
        {
            List<Permission> DataSource = await UnitOfWork.Permission.SelectAsync(x => x.Id == Model.Id);
            Permission permission = Mapper.Map<Permission>(DataSource[0]);
            permission.UpdateDate = DateTime.Now;

            await UnitOfWork.Permission.UpdateAsync(permission);
            int result = await UnitOfWork.SaveChangesAsync();

            return new PermissionResponse
            {
                Single = permission,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<PermissionResponse> DeleteAsync(PermissionDeleteDataTransfer Model)
        {
            List<Permission> permissionDataSource = await UnitOfWork.Permission.SelectAsync(x => x.Id == Model.Id);
            Permission permission = Mapper.Map<Permission>(permissionDataSource[0]);

            await UnitOfWork.Permission.DeleteAsync(permission);
            int result = await UnitOfWork.SaveChangesAsync();

            return new PermissionResponse
            {
                Single = permission,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<PermissionResponse> SelectAsync(PermissionSelectDataTransfer Model)
        {
            List<Permission> permissionDataSource = await UnitOfWork.Permission.SelectAsync(x => x.IsActive == true);
            return new PermissionResponse
            {
                List = permissionDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<PermissionResponse> AnyAsync(PermissionAnyDataTransfer Model)
        {
            List<Permission> permissionDataSource = await UnitOfWork.Permission.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new PermissionResponse
            {
                List = permissionDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}