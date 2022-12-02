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

        public async Task<UserEmailResponse> AddAsync(UserEmailInsertDataTransfer Model)
        {
            UserEmail userEmail = Mapper.Map<UserEmail>(Model);
            userEmail.Id = Guid.NewGuid();
            userEmail.RegisterDate = DateTime.Now;
            userEmail.UpdateDate = DateTime.Now;
            userEmail.IsActive = true;

            await UnitOfWork.UserEmail.AddAsync(userEmail);
            await UnitOfWork.SaveChangesAsync();

            return new UserEmailResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<UserEmailResponse> UpdateAsync(UserEmailUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEmailResponse> DeleteAsync(UserEmailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEmailResponse> SelectAsync(UserEmailSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEmailResponse> AnyAsync(UserEmailAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}