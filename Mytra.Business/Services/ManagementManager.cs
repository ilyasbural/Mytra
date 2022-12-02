namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementManager : BusinessObject<Management>, IManagementService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ManagementManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ManagementResponse> AddAsync(ManagementInsertDataTransfer Model)
        {
            Management management = Mapper.Map<Management>(Model);
            management.Id = Guid.NewGuid();
            management.RegisterDate = DateTime.Now;
            management.UpdateDate = DateTime.Now;
            management.IsActive = true;

            await UnitOfWork.Management.AddAsync(management);
            await UnitOfWork.SaveChangesAsync();

            return new ManagementResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<ManagementResponse> UpdateAsync(ManagementUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementResponse> DeleteAsync(ManagementDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementResponse> SelectAsync(ManagementSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementResponse> AnyAsync(ManagementAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}