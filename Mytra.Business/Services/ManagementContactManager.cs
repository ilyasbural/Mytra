namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementContactManager : BusinessObject<ManagementContact>, IManagementContactService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ManagementContactManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ManagementContactResponse> AddAsync(ManagementContactInsertDataTransfer Model)
        {
            ManagementContact managementContact = Mapper.Map<ManagementContact>(Model);
            managementContact.Id = Guid.NewGuid();
            managementContact.RegisterDate = DateTime.Now;
            managementContact.UpdateDate = DateTime.Now;
            managementContact.IsActive = true;

            await UnitOfWork.ManagementContact.AddAsync(managementContact);
            await UnitOfWork.SaveChangesAsync();

            return new ManagementContactResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<ManagementContactResponse> UpdateAsync(ManagementContactUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementContactResponse> DeleteAsync(ManagementContactDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}