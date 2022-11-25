namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class UserDetailManager : IUserDetailService, IDisposable
    {
        protected IMapper Mapper;
        public UserDetailManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}