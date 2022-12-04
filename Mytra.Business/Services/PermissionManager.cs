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

        public async Task<PermissionResponse> AddAsync(PermissionInsertDataTransfer Model)
        {
            Permission permission = Mapper.Map<Permission>(Model);
            permission.Id = Guid.NewGuid();
            permission.RegisterDate = DateTime.Now;
            permission.UpdateDate = DateTime.Now;
            permission.IsActive = true;

            await UnitOfWork.Permission.AddAsync(permission);
            await UnitOfWork.SaveChangesAsync();

            return new PermissionResponse { Permission= permission };
        }

        public async Task<PermissionResponse> UpdateAsync(PermissionUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
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