namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class SurveyManager : BusinessObject<Survey>, ISurveyService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public SurveyManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<SurveyResponse> AddAsync(SurveyInsertDataTransfer Model)
        {
            Survey survey = Mapper.Map<Survey>(Model);
            survey.Id = Guid.NewGuid();
            survey.RegisterDate = DateTime.Now;
            survey.UpdateDate = DateTime.Now;
            survey.IsActive = true;

            await UnitOfWork.Survey.AddAsync(survey);
            await UnitOfWork.SaveChangesAsync();

            return new SurveyResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<SurveyResponse> UpdateAsync(SurveyUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SurveyResponse> DeleteAsync(SurveyDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SurveyResponse> SelectAsync(SurveySelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SurveyResponse> AnyAsync(SurveyAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}