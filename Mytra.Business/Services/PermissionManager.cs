namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class PermissionManager : BusinessObject<Permission>, IPermissionService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public PermissionManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
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

            return new PermissionResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<PermissionResponse> UpdateAsync(PermissionUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PermissionResponse> DeleteAsync(PermissionDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}