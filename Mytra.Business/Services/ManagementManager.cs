namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementManager : BusinessObject<Management>, IManagementService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Management> Validator;

        public ManagementManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Management> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<ManagementResponse> InsertAsync(ManagementInsertDataTransfer Model)
        {
            Management management = Mapper.Map<Management>(Model);
            management.Id = Guid.NewGuid();
            management.RegisterDate = DateTime.Now;
            management.UpdateDate = DateTime.Now;
            management.IsActive = true;

            await UnitOfWork.Management.InsertAsync(management);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementResponse 
            { 
                Single = management, 
                Success = result ,
                Message = "Completed"
            };
        }

        public async Task<ManagementResponse> UpdateAsync(ManagementUpdateDataTransfer Model)
        {
            List<Management> DataSource = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id);
            Management management = Mapper.Map<Management>(DataSource[0]);
            management.UpdateDate = DateTime.Now;

            await UnitOfWork.Management.UpdateAsync(management);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementResponse
            {
                Single = management,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementResponse> DeleteAsync(ManagementDeleteDataTransfer Model)
        {
            List<Management> managementDataSource = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id);
            Management management = Mapper.Map<Management>(managementDataSource[0]);

            await UnitOfWork.Management.DeleteAsync(management);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ManagementResponse
            {
                Single = management,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<ManagementResponse> SelectAsync(ManagementSelectDataTransfer Model)
        {
            List<Management> managementDataSource = await UnitOfWork.Management.SelectAsync(x => x.IsActive == true);
            return new ManagementResponse
            {
                List = managementDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<ManagementResponse> AnyAsync(ManagementAnyDataTransfer Model)
        {
            List<Management> managementDataSource = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new ManagementResponse
            {
                List = managementDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}