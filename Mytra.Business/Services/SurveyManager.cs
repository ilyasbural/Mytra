namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class SurveyManager : ISurveyService, IDisposable
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public SurveyManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public Task<SurveyResponse> AddAsync(SurveyInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}