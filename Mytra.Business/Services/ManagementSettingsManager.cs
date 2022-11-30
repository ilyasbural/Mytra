namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementSettingsManager : IManagementSettingsService, IDisposable
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ManagementSettingsManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public Task<ManagementSettingsResponse> AddAsync(ManagementSettingsInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}