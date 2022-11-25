namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class UserManager : IUserService, IDisposable
    {
        protected IMapper Mapper;
        public UserManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}