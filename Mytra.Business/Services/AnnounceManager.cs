namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class AnnounceManager : IAnnounceService, IDisposable
    {
        protected IMapper Mapper;
        protected IUnitOfWork UnitOfWork;

        public AnnounceManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}