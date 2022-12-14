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

        public async Task<UserContactResponse> InsertAsync(UserContactInsertDataTransfer Model)
        {
            UserContact userContact = Mapper.Map<UserContact>(Model);
            userContact.Id = Guid.NewGuid();
            userContact.RegisterDate = DateTime.Now;
            userContact.UpdateDate = DateTime.Now;
            userContact.IsActive = true;

            await UnitOfWork.UserContact.InsertAsync(userContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserContactResponse 
            { 
                Single = userContact, 
                Success = result
            };
        }

        public async Task<UserContactResponse> UpdateAsync(UserContactUpdateDataTransfer Model)
        {
            List<UserContact> DataSource = await UnitOfWork.UserContact.SelectAsync(x => x.Id == Model.Id);
            UserContact userContact = Mapper.Map<UserContact>(DataSource[0]);
            userContact.UpdateDate = DateTime.Now;

            await UnitOfWork.UserContact.UpdateAsync(userContact);
            int result = await UnitOfWork.SaveChangesAsync();

            return new UserContactResponse 
            { 
                Single = userContact, 
                Success = result 
            };
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