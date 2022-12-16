namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class UserEmailManager : BusinessObject<UserEmail>, IUserEmailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<UserEmail> Validator;

        public UserEmailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserEmail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<UserEmailResponse> InsertAsync(UserEmailInsertDataTransfer Model)
        {
            UserEmail userEmail = Mapper.Map<UserEmail>(Model);
            userEmail.Id = Guid.NewGuid();
            userEmail.RegisterDate = DateTime.Now;
            userEmail.UpdateDate = DateTime.Now;
            userEmail.IsActive = true;

            await UnitOfWork.UserEmail.InsertAsync(userEmail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserEmailResponse 
            { 
                Single = userEmail, 
                Success = result ,
                Message = "Completed"
            };
        }

        public async Task<UserEmailResponse> UpdateAsync(UserEmailUpdateDataTransfer Model)
        {
            List<UserEmail> DataSource = await UnitOfWork.UserEmail.SelectAsync(x => x.Id == Model.Id);
            UserEmail userEmail = Mapper.Map<UserEmail>(DataSource[0]);
            userEmail.UpdateDate = DateTime.Now;

            await UnitOfWork.UserEmail.UpdateAsync(userEmail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserEmailResponse 
            { 
                Single = userEmail, 
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<UserEmailResponse> DeleteAsync(UserEmailDeleteDataTransfer Model)
        {
            List<UserEmail> userEmailDataSource = await UnitOfWork.UserEmail.SelectAsync(x => x.Id == Model.Id);
            UserEmail userEmail = Mapper.Map<UserEmail>(userEmailDataSource[0]);

            await UnitOfWork.UserEmail.DeleteAsync(userEmail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserEmailResponse
            {
                Single = userEmail,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<UserEmailResponse> SelectAsync(UserEmailSelectDataTransfer Model)
        {
            List<UserEmail> userEmailDataSource = await UnitOfWork.UserEmail.SelectAsync(x => x.IsActive == true);
            return new UserEmailResponse
            {
                List = userEmailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<UserEmailResponse> AnyAsync(UserEmailAnyDataTransfer Model)
        {
            List<UserEmail> userEmailDataSource = await UnitOfWork.UserEmail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new UserEmailResponse
            {
                List = userEmailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}