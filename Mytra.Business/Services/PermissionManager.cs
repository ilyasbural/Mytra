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
                Success = result 
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
                Success = result
            };
        }

        public async Task<PermissionResponse> DeleteAsync(PermissionDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PermissionResponse> SelectAsync(PermissionSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PermissionResponse> AnyAsync(PermissionAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}