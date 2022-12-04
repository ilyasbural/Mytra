namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class SurveyManager : BusinessObject<Survey>, ISurveyService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Survey> Validator;

        public SurveyManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Survey> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
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

            return new SurveyResponse { Survey = survey };
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