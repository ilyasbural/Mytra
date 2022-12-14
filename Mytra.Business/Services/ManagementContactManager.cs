namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementContactManager : BusinessObject<ManagementContact>, IManagementContactService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ManagementContact> Validator;

        public ManagementContactManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagementContact> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<ManagementContactResponse> InsertAsync(ManagementContactInsertDataTransfer Model)
        {
            ManagementContact managementContact = Mapper.Map<ManagementContact>(Model);
            managementContact.Id = Guid.NewGuid();
            managementContact.RegisterDate = DateTime.Now;
            managementContact.UpdateDate = DateTime.Now;
            managementContact.IsActive = true;

            await UnitOfWork.ManagementContact.InsertAsync(managementContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementContactResponse 
            { 
                Single = managementContact, 
                Success = result 
            };
        }

        public async Task<ManagementContactResponse> UpdateAsync(ManagementContactUpdateDataTransfer Model)
        {
            List<ManagementContact> DataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id);
            ManagementContact managementContact = Mapper.Map<ManagementContact>(DataSource[0]);
            managementContact.UpdateDate = DateTime.Now;

            await UnitOfWork.ManagementContact.UpdateAsync(managementContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementContactResponse
            {
                Single = managementContact,
                Success = result
            };
        }

        public async Task<ManagementContactResponse> DeleteAsync(ManagementContactDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementContactResponse> SelectAsync(ManagementContactSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementContactResponse> AnyAsync(ManagementContactAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}