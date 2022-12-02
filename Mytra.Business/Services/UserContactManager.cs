namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class UserContactManager : BusinessObject<UserContact>, IUserContactService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<UserContact> Validator;

        public UserContactManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserContact> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<UserContactResponse> AddAsync(UserContactInsertDataTransfer Model)
        {
            UserContact userContact = Mapper.Map<UserContact>(Model);
            userContact.Id = Guid.NewGuid();
            userContact.RegisterDate = DateTime.Now;
            userContact.UpdateDate = DateTime.Now;
            userContact.IsActive = true;

            await UnitOfWork.UserContact.AddAsync(userContact);
            await UnitOfWork.SaveChangesAsync();

            return new UserContactResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<UserContactResponse> UpdateAsync(UserContactUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserContactResponse> DeleteAsync(UserContactDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserContactResponse> SelectAsync(UserContactSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserContactResponse> AnyAsync(UserContactAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}