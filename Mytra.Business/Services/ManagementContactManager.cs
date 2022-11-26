namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementContactManager : IManagementContactService, IDisposable
    {
        protected IMapper Mapper;
        protected IUnitOfWork UnitOfWork;

        public ManagementContactManager(IMapper mapper, IUnitOfWork unitOfWork)
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