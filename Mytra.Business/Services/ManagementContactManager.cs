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
                Success = result,
                Message = "Completed"
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
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementContactResponse> DeleteAsync(ManagementContactDeleteDataTransfer Model)
        {
            List<ManagementContact> managementContactDataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id);
            ManagementContact managementContact = Mapper.Map<ManagementContact>(managementContactDataSource[0]);

            await UnitOfWork.ManagementContact.DeleteAsync(managementContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementContactResponse
            {
                Single = managementContact,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementContactResponse> SelectAsync(ManagementContactSelectDataTransfer Model)
        {
            List<ManagementContact> managementDataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.IsActive == true);
            return new ManagementContactResponse
            {
                List = managementDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ManagementContactResponse> AnyAsync(ManagementContactAnyDataTransfer Model)
        {
            List<ManagementContact> managementContactDataSource = await UnitOfWork.ManagementContact.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ManagementContactResponse
            {
                List = managementContactDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}