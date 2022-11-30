namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class SurveyDetailManager : ISurveyDetailService, IDisposable
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public SurveyDetailManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public Task<SurveyDetailResponse> AddAsync(SurveyDetailInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}