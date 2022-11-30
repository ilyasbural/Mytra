namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class PermissionDetailManager : IPermissionDetailService, IDisposable
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public PermissionDetailManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public Task<PermissionDetailResponse> AddAsync(PermissionDetailInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}