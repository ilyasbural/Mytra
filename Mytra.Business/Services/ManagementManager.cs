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
    }
}