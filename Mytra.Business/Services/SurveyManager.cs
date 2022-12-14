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

        public async Task<SurveyResponse> InsertAsync(SurveyInsertDataTransfer Model)
        {
            Survey survey = Mapper.Map<Survey>(Model);
            survey.Id = Guid.NewGuid();
            survey.RegisterDate = DateTime.Now;
            survey.UpdateDate = DateTime.Now;
            survey.IsActive = true;

            await UnitOfWork.Survey.InsertAsync(survey);
            int result = await UnitOfWork.SaveChangesAsync();

            return new SurveyResponse 
            { 
                Single = survey, 
                Success = result  
            };
        }

        public async Task<SurveyResponse> UpdateAsync(SurveyUpdateDataTransfer Model)
        {
            List<Survey> DataSource = await UnitOfWork.Survey.SelectAsync(x => x.Id == Model.Id);
            Survey survey = Mapper.Map<Survey>(DataSource[0]);
            survey.UpdateDate = DateTime.Now;

            await UnitOfWork.Survey.UpdateAsync(survey);
            int result = await UnitOfWork.SaveChangesAsync();

            return new SurveyResponse
            {
                Single = survey,
                Success = result
            };
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