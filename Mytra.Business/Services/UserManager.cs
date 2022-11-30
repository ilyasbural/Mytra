namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class UserManager : IUserService, IDisposable
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public UserManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public Task<UserResponse> AddAsync(UserInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}