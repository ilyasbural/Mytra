namespace Mytra.Business
{
    using Core;
    using AutoMapper;

    public class SurveyManager : ISurveyService, IDisposable
    {
        protected IMapper Mapper;
        public SurveyManager(IMapper mapper)
        {
            Mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}